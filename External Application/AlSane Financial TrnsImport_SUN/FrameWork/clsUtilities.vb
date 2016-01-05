Imports System.IO
Public Class clsUtilities

#Region "Declartion"
    Private objCompany As SAPbobsCOM.Company
    Private oblclsbo As ClsSBO

#End Region

#Region "Methods"

#Region "Constructor"

    Public Sub New(ByVal objSBO As ClsSBO)
        oblclsbo = objSBO
    End Sub
    Public Sub New()
    End Sub

#End Region

#Region "Write into ErrorLog File"
    Private Sub WriteErrorHeader(ByVal apath As String, ByVal strMessage As String)
        Dim aSw As System.IO.StreamWriter
        Dim aMessage As String
        aMessage = Now.ToLocalTime & "---" & strMessage
        If File.Exists(apath) Then
        End If
        aSw = New StreamWriter(apath, True)
        aSw.WriteLine(aMessage)
        aSw.Flush()
        aSw.Close()
    End Sub
    Private Sub WriteErrorlog(ByVal aMessage As String, ByVal aPath As String)
        Dim aSw As System.IO.StreamWriter
        If File.Exists(aPath) Then
        End If
        aSw = New StreamWriter(aPath, True)
        aMessage = Now.ToLocalTime & "---" & aMessage
        aSw.WriteLine(aMessage)
        aSw.Flush()
        aSw.Close()
    End Sub
#End Region

#Region "Create Production Order"
#Region "Update Quantity and WHS"
    Private Sub UpdateQuantityandWhs(ByVal aDocNum As String)
        Dim dblQty As Double
        Dim oTempLines, oTemprs, oTempHeader As SAPbobsCOM.Recordset
        oTemprs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTempLines = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTempHeader = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemprs.DoQuery("Select * from [@DABT_BOMHeader] where (U_Type='N' or U_Type='Q') and U_SODocNum ='" & aDocNum & "'")
        For intRow As Integer = 0 To oTemprs.RecordCount - 1
            Dim strSry As String
            strSry = "Select * from RDR1 where U_BOMRef='" & oTemprs.Fields.Item("Code").Value & "' and DocEntry=(Select DocEntry from ORDR where Docnum='" & aDocNum & "')"
            oTempLines.DoQuery(strSry)
            dblQty = oTempLines.Fields.Item("Quantity").Value
            'strSry = "Update [@DABT_BOMHeader] set U_SOLineNo=" & oTempLines.Fields.Item("LineNum").Value & ", U_WhsCode='" & oTempLines.Fields.Item("WhsCode").Value & "', U_PlnQty='" & oTempLines.Fields.Item("Quantity").Value & "' where code='" & oTemprs.Fields.Item("Code").Value & "'"
            ' strSry = "Update [@DABT_BOMHeader] set U_SOLineNo=" & oTempLines.Fields.Item("LineNum").Value & ", U_WhsCode='" & oTempLines.Fields.Item("WhsCode").Value & "', U_PlnQty='" & dblQty & "' where code='" & oTemprs.Fields.Item("Code").Value & "'"
            strSry = "Update [@DABT_BOMHeader] set U_IsProd='" & oTempLines.Fields.Item("U_IsProd").Value & "', U_SOLineNo=" & oTempLines.Fields.Item("LineNum").Value & ", U_WhsCode='" & oTempLines.Fields.Item("WhsCode").Value & "', U_PlnQty='" & dblQty & "' where code='" & oTemprs.Fields.Item("Code").Value & "'"
            oTempHeader.DoQuery(strSry)
            oTemprs.MoveNext()
        Next
    End Sub
#End Region

#Region "Check whether the Production order creation check"
    Private Function CheckProductionCheck(ByVal strDocNum As String) As Boolean
        Dim strSOSql As String
        Dim objrs As SAPbobsCOM.Recordset
        objrs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        strSOSql = "Select * from [@DABT_BOMHeader] where U_SODocNum='" & strDocNum & "'  and U_Type='N'"
        objrs.DoQuery(strSOSql)
        If objrs.RecordCount > 0 Then
            Return True
        End If
        Return False
    End Function
#End Region

#Region "Cancel Production Order"
    Private Function CancelProductionOrder(ByVal strSODocNum As String) As Boolean
        Dim objProductionOrder As SAPbobsCOM.ProductionOrders
        Dim objRs, objRSLines, otemprs As SAPbobsCOM.Recordset
        Dim strDocNum, strSOSql, strBOMRefNo, strPOdocNum As String
        Dim intDocEntry, intStatus As Integer
        Try
            strDocNum = strSODocNum
            objRs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            objRs.DoQuery("select * from ORDR where DocNum='" & strDocNum & "'")
            intDocEntry = objRs.Fields.Item("DocEntry").Value
            objRSLines = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            strSOSql = "Select * from [@DABT_BOMHeader] where U_SODocNum='" & strDocNum & "'  and U_Type='U'"
            objRs.DoQuery(strSOSql)
            For intHeader As Integer = 0 To objRs.RecordCount - 1
                objProductionOrder = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders)
                intDocEntry = objRs.Fields.Item("U_PORef").Value
                If intDocEntry <> 0 Then
                    If objProductionOrder.GetByKey((intDocEntry)) Then
                        strPOdocNum = objProductionOrder.DocumentNumber
                        strBOMRefNo = objRs.Fields.Item("Code").Value
                        If objProductionOrder.ProductionOrderStatus <> SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled And objProductionOrder.ProductionOrderStatus <> SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed Then
                            objProductionOrder.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled
                            'If objProductionOrder.Update <> 0 Then
                            If objProductionOrder.Cancel <> 0 Then
                                ' ShowMessage(CompanyObject.ge.GetLastErrorDescription)
                                Return False
                            Else
                                otemprs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                                otemprs.DoQuery("Update [@DABT_BOMHeader] set U_Type='D'  where Code='" & objRs.Fields.Item("Code").Value & "'")
                                WriteErrorlog("Production order : " & strPOdocNum & " Canceled", strErrorLogPath)
                            End If
                        End If

                    End If
                End If
                objRs.MoveNext()
            Next
            Return True
        Catch ex As Exception
            ShowMessage(ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "Update Production Order"
    Private Function UpdateProductionOrder(ByVal strSODocNum As String) As Boolean
        Dim objProductionOrder As SAPbobsCOM.ProductionOrders
        Dim objRs, objRSLines, otemprs As SAPbobsCOM.Recordset
        Dim strDocNum, strSOSql, strBOMRefNo, strPoDocNum As String
        Dim intDocEntry, intStatus As Integer
        Dim dblplnqty As Double
        Try
            strDocNum = strSODocNum
            objRs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            objRs.DoQuery("select * from ORDR where DocNum='" & strDocNum & "'")
            intDocEntry = objRs.Fields.Item("DocEntry").Value
            objRSLines = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            strSOSql = "Select * from [@DABT_BOMHeader] where U_SODocNum='" & strDocNum & "'  and U_Type='Q'"
            objRs.DoQuery(strSOSql)
            For intHeader As Integer = 0 To objRs.RecordCount - 1
                objProductionOrder = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders)
                intDocEntry = objRs.Fields.Item("U_PORef").Value
                If intDocEntry <> 0 Then
                    If objProductionOrder.GetByKey((intDocEntry)) Then
                        dblplnqty = objRs.Fields.Item("U_Plnqty").Value
                        strBOMRefNo = objRs.Fields.Item("Code").Value
                        strPoDocNum = objProductionOrder.DocumentNumber
                        If objProductionOrder.ProductionOrderStatus <> SAPbobsCOM.BoProductionOrderStatusEnum.boposCancelled And objProductionOrder.ProductionOrderStatus <> SAPbobsCOM.BoProductionOrderStatusEnum.boposClosed Then
                            objProductionOrder.PlannedQuantity = dblplnqty
                            If objProductionOrder.Update <> 0 Then
                                '  ShowMessage(CompanyObject.GetLastErrorDescription)
                                Return False
                            Else
                                otemprs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                                otemprs.DoQuery("Update [@DABT_BOMHeader] set U_Type='A'  where Code='" & objRs.Fields.Item("Code").Value & "'")
                                WriteErrorlog("Production Order : " & strPoDocNum & " Updated", strErrorLogPath)
                            End If
                        End If

                    End If
                End If
                objRs.MoveNext()
            Next
            Return True
        Catch ex As Exception
            ShowMessage(ex.Message)
            Return False
        End Try
    End Function
#End Region

    Public Sub PostProductionOrders()
        Dim oDocNum As String
        Dim blnErrorflag As Boolean
        Dim otemprs, oPORs As SAPbobsCOM.Recordset
        oDocNum = "309"
        oPORs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oPORs.DoQuery("select * from ORDR where DocNum in (Select U_SODocNum  from [@DABT_BOMHeader] where U_Type<>'A')")
        If CompanyObject.InTransaction Then
            CompanyObject.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
        End If
        strErrorLogPath = strErrorFileName
        CompanyObject.StartTransaction()
        For intRow As Integer = 0 To oPORs.RecordCount - 1
            oDocNum = oPORs.Fields.Item("DocNum").Value
            'ShowWarningMessage()
            WriteErrorlog("Processing sales order : " & oDocNum, strErrorLogPath)
            If CreateProductionOrders(oDocNum) = False Then
                If (blnErrorflag = True) Then
                Else
                    If CompanyObject.InTransaction() Then
                        CompanyObject.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                    End If
                End If
            Else
                otemprs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                otemprs.DoQuery("Update [@DABT_BOMHeader] set Name=Code where  isnull(U_IsProd,'Y')='Y' and Name like '%N' and U_SODocNum='" & oDocNum & "'")
                otemprs.DoQuery("Update [@DABT_BOMLines] set Name=Code where Name like '%N' and U_BOMRef in (Select code from [@DABT_BOMHeader] where isnull(U_IsProd,'Y')='Y' and U_SODocNum='" & oDocNum & "')")
                otemprs.DoQuery("Delete from [@DABT_BOMLines] where  U_BOMRef in (Select code from [@DABT_BOMHeader] where U_Type='D' and U_SODocNum='" & oDocNum & "')")
                otemprs.DoQuery("Delete from [@DABT_BOMHeader] where U_Type='D' and U_SODocNum='" & oDocNum & "'")
                otemprs.DoQuery("Update [@DABT_BOMHeader] set U_Type='A' where U_Type <>'N' and U_SODocNum='" & oDocNum & "'")
                ShowSuccessMessage("Operation Compleated successfullY")
                If CompanyObject.InTransaction() Then
                    CompanyObject.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                End If
            End If
            oPORs.MoveNext()
        Next
        WriteErrorlog("Operation completed succuessfully", strErrorLogPath)
    End Sub

#Region "Check the production Flag"
    Private Function checkProductionflag(ByVal aDocNum As String) As Boolean
        Dim oTemp1 As SAPbobsCOM.Recordset
        Dim strSry As String
        oTemp1 = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        strSry = "Select isnull(U_IsProd,'Y') from RDR1 where U_BOMRef='" & aDocNum & "'"
        oTemp1.DoQuery(strSry)
        If oTemp1.Fields.Item(0).Value = "Y" Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

    Public Function CreateProductionOrders(ByVal strSODocNum As String) As Boolean
        Dim objProductionOrder As SAPbobsCOM.ProductionOrders
        Dim objRs, objRSLines, otemprs As SAPbobsCOM.Recordset
        Dim strDocNum, strSOSql, strSOLinesStandared, strSOLinesOptional, strDocEntry, Cardcode As String
        Dim intNoofLines, intDocEntry As Integer
        Dim dtPostingdate As Date
        strDocNum = strSODocNum
        Try
            UpdateQuantityandWhs(strSODocNum)
            UpdateQuantityandWhs(strSODocNum)
            If UpdateProductionOrder(strSODocNum) = False Then
                Return False
            End If
            If CancelProductionOrder(strSODocNum) = False Then
                Return False
            End If
            If CheckProductionCheck(strSODocNum) = False Then
                Return True
            End If

            objRs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            objRs.DoQuery("select * from ORDR where DocNum='" & strDocNum & "'")
            Cardcode = objRs.Fields.Item("CardCode").Value
            intDocEntry = objRs.Fields.Item("DocEntry").Value
            dtPostingdate = objRs.Fields.Item("DocDate").Value
            objRSLines = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            strSOSql = "Select * from [@DABT_BOMHeader] where isnull(U_IsProd,'Y')='Y' and U_SODocNum='" & strDocNum & "'  and U_Type='N'"
            objRs.DoQuery(strSOSql)
            For intHeader As Integer = 0 To objRs.RecordCount - 1
                If checkProductionflag(objRs.Fields.Item("Code").Value) = False Then 'ManagedProduction() = False Then
                    'otemprs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    'otemprs.DoQuery("Update [@DABT_BOMHeader] set U_Type='A',name=code  where  Code='" & objRs.Fields.Item("Code").Value & "'")
                    'otemprs.DoQuery("Update [@DABT_BOMLines] set Name=Code where Name like '%N' and U_BOMRef ='" & objRs.Fields.Item("Code").Value & "'")
                Else
                    intNoofLines = 0
                    strSOLinesStandared = "Select isnull(count(*),0) from ITT1 where Father='" & objRs.Fields.Item("U_ItemCode").Value & "' and U_BOMRwTp='1'"
                    objRSLines.DoQuery(strSOLinesStandared)
                    intNoofLines = intNoofLines + CInt(objRSLines.Fields.Item(0).Value)
                    strSOLinesStandared = "Select isnull(count(*),0) from [@DABT_BOMLines] where U_BOMRef='" & objRs.Fields.Item("Code").Value & "'"
                    objRSLines.DoQuery(strSOLinesStandared)
                    intNoofLines = intNoofLines + CInt(objRSLines.Fields.Item(0).Value)
                    If intNoofLines > 0 Then
                        objProductionOrder = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductionOrders)
                        objProductionOrder.ItemNo = objRs.Fields.Item("U_ItemCode").Value
                        objProductionOrder.PlannedQuantity = objRs.Fields.Item("U_PlnQty").Value
                        objProductionOrder.PostingDate = dtPostingdate
                        objProductionOrder.DueDate = dtPostingdate
                        objProductionOrder.CustomerCode = Cardcode
                        objProductionOrder.ProductionOrderOrigin = SAPbobsCOM.BoProductionOrderOriginEnum.bopooSalesOrder
                        objProductionOrder.ProductionOrderOriginEntry = intDocEntry
                        objProductionOrder.Warehouse = objRs.Fields.Item("U_WhsCode").Value
                        strSOLinesStandared = "Select * from ITT1 where Father='" & objRs.Fields.Item("U_ItemCode").Value & "' and U_BOMRwTp=1"
                        objRSLines.DoQuery(strSOLinesStandared)
                        intNoofLines = 0
                        For intLoop As Integer = 0 To objRSLines.RecordCount - 1
                            If intNoofLines > 0 Then
                                objProductionOrder.Lines.Add()
                            End If
                            objProductionOrder.Lines.ItemNo = objRSLines.Fields.Item("Code").Value
                            objProductionOrder.Lines.BaseQuantity = objRSLines.Fields.Item("Quantity").Value
                            objProductionOrder.Lines.Warehouse = objRs.Fields.Item("U_WhsCode").Value
                            objProductionOrder.Lines.UserFields.Fields.Item("U_WasOptn").Value = 1
                            If CheckInventoryItem(objRSLines.Fields.Item("Code").Value) = True Then
                                objProductionOrder.Lines.ProductionOrderIssueType = SAPbobsCOM.BoIssueMethod.im_Manual
                            Else
                                objProductionOrder.Lines.ProductionOrderIssueType = SAPbobsCOM.BoIssueMethod.im_Backflush
                            End If
                            intNoofLines = intNoofLines + 1
                            objRSLines.MoveNext()
                        Next
                        strSOLinesStandared = "Select * from [@DABT_BOMLines] where U_BOMRef='" & objRs.Fields.Item("Code").Value & "'"
                        objRSLines.DoQuery(strSOLinesStandared)
                        For intLoop As Integer = 0 To objRSLines.RecordCount - 1
                            If intNoofLines > 0 Then
                                objProductionOrder.Lines.Add()
                            End If
                            objProductionOrder.Lines.ItemNo = objRSLines.Fields.Item("U_ItemCode").Value
                            objProductionOrder.Lines.BaseQuantity = objRSLines.Fields.Item("U_BaseQty").Value
                            objProductionOrder.Lines.Warehouse = objRs.Fields.Item("U_WhsCode").Value
                            objProductionOrder.Lines.UserFields.Fields.Item("U_WasOptn").Value = 2
                            If CheckInventoryItem(objRSLines.Fields.Item("U_ItemCode").Value) = True Then
                                objProductionOrder.Lines.ProductionOrderIssueType = SAPbobsCOM.BoIssueMethod.im_Manual
                            Else
                                objProductionOrder.Lines.ProductionOrderIssueType = SAPbobsCOM.BoIssueMethod.im_Backflush
                            End If
                            intNoofLines = intNoofLines + 1
                            objRSLines.MoveNext()
                        Next
                        If (objProductionOrder.Add() <> 0) Then
                            WriteErrorlog(CompanyObject.GetLastErrorDescription, strErrorLogPath)
                            Return False
                        Else
                            Dim PODocNum As String
                            strDocEntry = CompanyObject.GetNewObjectKey()
                            PODocNum = GetProductionDocEntry(strDocEntry)
                            otemprs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                            otemprs.DoQuery("Update RDR1 set U_PODocNum='" & PODocNum & "', U_PONO=" & strDocEntry & " where Docentry='" & intDocEntry & "' and U_BOMRef='" & objRs.Fields.Item("Code").Value & "'")
                            otemprs.DoQuery("Update [@DABT_BOMHeader] set U_Type='A', U_PORef=" & strDocEntry & " where Code='" & objRs.Fields.Item("Code").Value & "'")
                            Dim intLine As Integer
                            otemprs.DoQuery("Select LineNum from RDR1  where quantity=openqty and Docentry='" & intDocEntry & "' and U_BOMRef='" & objRs.Fields.Item("Code").Value & "'")
                            If otemprs.RecordCount > 0 Then
                                intLine = otemprs.Fields.Item(0).Value
                                UpdateSalesPrice(intDocEntry, intLine)
                            End If
                            Dim strpoDocNum As String
                            If objProductionOrder.GetByKey(CInt(strDocEntry)) Then
                                objProductionOrder.ProductionOrderStatus = SAPbobsCOM.BoProductionOrderStatusEnum.boposReleased
                                strpoDocNum = objProductionOrder.DocumentNumber
                                If objProductionOrder.Update <> 0 Then
                                    WriteErrorlog(CompanyObject.GetLastErrorDescription, strErrorLogPath)
                                    Return False
                                Else
                                    WriteErrorlog("Production Order " & strpoDocNum & ": created ", strErrorLogPath)
                                End If
                            End If
                        End If
                    End If
                    '    Return True
                End If
                objRs.MoveNext()
            Next
            Return True
        Catch ex As Exception
            WriteErrorlog(ex.Message, strErrorLogPath)
            Return False
        End Try
    End Function
#End Region

#Region "Update Sales Price"
    Public Function UpdateSalesPrice(ByVal aDocEntry As Integer, ByVal aIntRow As Integer) As Boolean
        Dim oSalesOrder As SAPbobsCOM.Documents
        oSalesOrder = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders)
        Dim oTem As SAPbobsCOM.Recordset
        Dim dblqty, dblprice As Double
        oTem = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTem.DoQuery("Select isnull(U_SalesPrc,'N') from OADM")
        If oTem.Fields.Item(0).Value = "Y" Then
            If oSalesOrder.GetByKey(aDocEntry) Then
                oSalesOrder.Lines.SetCurrentLine(aIntRow)
                If oSalesOrder.Lines.LineStatus = SAPbobsCOM.BoStatus.bost_Open Then
                    dblqty = oSalesOrder.Lines.Quantity
                    dblprice = UpdateSalesPricefromProductionOrder(oSalesOrder.Lines.UserFields.Fields.Item("U_PONo").Value, oSalesOrder.Lines.ItemCode)
                    dblprice = dblprice
                    Dim dblexchange As Double
                    If oSalesOrder.DocCurrency <> GetLocalCurrency() Then
                        oSalesOrder.Lines.Currency = oSalesOrder.DocCurrency
                        dblexchange = ExchangeRate(oSalesOrder.DocDate, oSalesOrder.DocCurrency)
                    Else
                        dblexchange = 1
                    End If
                    oSalesOrder.Lines.UnitPrice = dblprice / dblexchange
                    If oSalesOrder.Update <> 0 Then
                        WriteErrorlog(CompanyObject.GetLastErrorDescription, strErrorLogPath)
                        Return False
                    End If
                Else

                End If
            End If
        End If
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oSalesOrder)
        Return True
    End Function
#End Region


    Private Function GetLocalCurrency() As String
        Dim oTemp As SAPbobsCOM.Recordset
        Dim strSQL, strSegmentation As String
        strSQL = "Select Maincurncy from OADM"
        oTemp = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemp.DoQuery(strSQL)
        strSegmentation = oTemp.Fields.Item(0).Value
        Return strSegmentation
    End Function

    Private Function ExchangeRate(ByVal dat As Date, ByVal strcurrency As String) As Double
        Dim RsXch As SAPbobsCOM.Recordset
        RsXch = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim strsql As String
        strsql = "Select isnull(Rate,0) from ortt where RateDate ='" & dat.ToString("yyyyMMdd") & "' and currency='" & strcurrency & "'"
        RsXch.DoQuery(strsql)
        If RsXch.EoF = False Then
            Return RsXch.Fields.Item(0).Value
        Else
            Return 0
        End If

    End Function


#Region "Get Sales price from Production Order"
    Public Function UpdateSalesPricefromProductionOrder(ByVal strDocNum As String, ByVal aItemCode As String) As Double
        Dim strSql As String
        Dim dblprice, dblPercentage, dblBasePrice, dblExchangerate As Double
        Dim otemp As SAPbobsCOM.Recordset
        Dim strLocalcurrency, strItemCurreny As String
        strLocalcurrency = GetLocalCurrency()
        otemp = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        otemp.DoQuery("Select isnull(U_PrsLst,'-1') from OADM")
        Dim strpricelist As String
        strpricelist = otemp.Fields.Item(0).Value
        If strpricelist = "-1" Then
            strSql = "SELECT T0.[DocEntry] ,T0.ItemCode,isnull(T1.LastPurPrc,0),isnull(T1.LastPurCur,''),T0.BaseQty  FROM WOR1 T0  INNER JOIN OITM T1 ON T0.ItemCode = T1.ItemCode WHERE T0.[DocEntry] ='" & strDocNum & "' Order by T0.[DocEntry]"
        Else
            strSql = "SELECT T0.[DocEntry] ,T0.ItemCode,isnull(T1.Price,0),isnull(T1.Currency,''),T0.BaseQty  FROM WOR1 T0  left outer JOIN ITM1 T1 ON T0.ItemCode = T1.ItemCode and T1.PriceList='" & strpricelist & "' WHERE T0.[DocEntry] ='" & strDocNum & "' Order by T0.[DocEntry]"
        End If
        otemp.DoQuery(strSql)
        dblBasePrice = 0
        dblprice = 0
        For intRow As Integer = 0 To otemp.RecordCount - 1
            strItemCurreny = otemp.Fields.Item(3).Value
            If strItemCurreny = "" Then
                strItemCurreny = strLocalcurrency
            End If
            ' MsgBox(otemp.Fields.Item(1).Value)
            If strLocalcurrency <> strItemCurreny Then
                dblBasePrice = otemp.Fields.Item(4).Value
                dblExchangerate = ExchangeRate(Now.Date, strItemCurreny)

            Else
                dblBasePrice = otemp.Fields.Item(4).Value
                dblExchangerate = 1

            End If
            dblprice = dblprice + (dblBasePrice * otemp.Fields.Item(2).Value * dblExchangerate)
            otemp.MoveNext()
        Next

        '        dblprice = otemp.Fields.Item(1).Value
        'SELECT T0.[LastPurCur], T0.[LastPurDat], T0.[LastPurPrc], T0.[ItemCode] FROM OITM T0

        strSql = "Select isnull(U_GrsPrf,0) from OITM where Itemcode='" & aItemCode & "'"
        otemp.DoQuery(strSql)
        dblPercentage = otemp.Fields.Item(0).Value
        dblprice = dblprice + (dblprice * dblPercentage) / 100
        Return dblprice
    End Function
#End Region


#Region "GetProductionDocEntry"
    Public Function GetProductionDocEntry(ByVal strPO As String) As String
        Dim oRs As SAPbobsCOM.Recordset
        oRs = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRs.DoQuery("select DocNum from OWOR where DocEntry='" & strPO & "'")
        Return (oRs.Fields.Item(0).Value)
    End Function
#End Region
#Region "Show Messages"
    '*****************************************************************
    'Type               : Procedure   
    'Name               : ShowMessage
    'Parameter          : Message
    'Return Value       : 
    'Author             : Senthil Kumar B Senthil Kumar B
    'Created Date       : 
    'Last Modified By   : 
    'Modified Date      : 
    'Purpose            : To Show Message with in SBO
    '*****************************************************************
    Public Sub ShowMessage(ByVal strMessage As String)
        '  CompanyObject.SBO_Appln.MessageBox(strMessage)
    End Sub
    '*****************************************************************
    'Type               : Procedure   
    'Name               : ShowSuccessMessage
    'Parameter          : Message
    'Return Value       : 
    'Author             : Senthil Kumar B Senthil Kumar B
    'Created Date       : 
    'Last Modified By   : 
    'Modified Date      : 
    'Purpose            : To Show Success Message in Status Bar
    '*****************************************************************

    Public Sub ShowSuccessMessage(ByVal strMessage As String)
        ' CompanyObject.SBO_Appln.StatusBar.SetText(strMessage, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
    End Sub
    '*****************************************************************
    'Type               : Procedure   
    'Name               : ShowErrorMessage
    'Parameter          : Message
    'Return Value       : 
    'Author             : Senthil Kumar B Senthil Kumar B
    'Created Date       : 
    'Last Modified By   : 
    'Modified Date      : 
    'Purpose            : To Show Error Message in Status Bar
    '*****************************************************************

    Public Sub ShowErrorMessage(ByVal strMessage As String)
        '  CompanyObject.SBO_Appln.StatusBar.SetText(strMessage, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
    End Sub

    '*****************************************************************
    'Type               : Procedure   
    'Name               : ShowWarningMessage
    'Parameter          : Message
    'Return Value       : 
    'Author             : Senthil Kumar B Senthil Kumar B
    'Created Date       : 
    'Last Modified By   : 
    'Modified Date      : 
    'Purpose            : To Show Warning Message in Status Bar
    '*****************************************************************

    Public Sub ShowWarningMessage(ByVal strMessage As String)
        '   CompanyObject..SBO_Appln.StatusBar.SetText(strMessage, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
    End Sub
#End Region

#Region "Check ItemType"
    Public Function CheckInventoryItem(ByVal strItemcode As String) As Boolean
        Dim oRsItem As SAPbobsCOM.Recordset
        oRsItem = CompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRsItem.DoQuery("Select InvntItem from OITM where itemcode='" & strItemcode & "'")
        If oRsItem.Fields.Item(0).Value <> "Y" Then
            Return False
        End If
        Return True
    End Function
#End Region



#End Region

End Class
