<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="WebApplication1.Customer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjectDataSource1">
        <Columns>
          <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
          <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
          <asp:BoundField DataField="Surname" HeaderText="Surname" 
            SortExpression="Surname" />
          <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" 
            SortExpression="BirthDate" />
          <asp:BoundField DataField="Address" HeaderText="Address" 
            SortExpression="Address" />
          <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
          <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" 
            SortExpression="PhoneNumber" />
          <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
          <asp:BoundField DataField="MobileNumber" HeaderText="MobileNumber" 
            SortExpression="MobileNumber" />
          <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
      </asp:GridView>
    
    </div>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
      DataObjectTypeName="Model.Customer" SelectMethod="GetCustomers" 
      TypeName="BusinessLogic.Customer_BL" UpdateMethod="UpdateCustomer">
    </asp:ObjectDataSource>
    </form>
</body>
</html>
