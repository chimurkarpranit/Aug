<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample.aspx.cs" Inherits="Day_2_4.Sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

        <style type="text/css">  
            .Gridview {  
                font-family: Verdana;  
                font-size: 10pt;  
                font-weight: normal;  
                color: black;  
            }  
        </style>  
        <script type="text/javascript">  
        </script>  
    </head>  
  
    <body>  
        <form id="form1" runat="server">  
            <br />
            <br />
            <br />
           <div align="center"> 
                <asp:GridView ID="GridView1" Caption='<h2>Employee Details</h2>' runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeID" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">  
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>  
                         <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" /> 
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" />  
                        <asp:BoundField DataField="LastName" HeaderText="LastName" />  
                        <asp:BoundField DataField="Address" HeaderText="Address" />  
                        <asp:BoundField DataField="Salary" HeaderText="Salary" /> 
                         <asp:BoundField DataField="Notes" HeaderText="Notes" /> 
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" /> </Columns>  
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>  
            </div>  
            <div>  
                <br />
                <br />
                <table align="center" border="1" cellpadding="0" cellspacing="0" style="border-collapse: collapse;
    width: 450px">
    <tr>
        <td style="width: 150px">
            FirstName:<br />
            <asp:TextBox ID="txtFirstName" runat="server" Width="140" />
        </td>
        <td style="width: 150px">
            LastName:<br />
            <asp:TextBox ID="txtLastName" runat="server" Width="140" />
        </td>
         <td style="width: 150px">
            Address:<br />
            <asp:TextBox ID="txtAddress" runat="server" Width="140" />
        </td>
         <td style="width: 150px">
            Salary:<br />
            <asp:TextBox ID="txtSalary" runat="server" Width="140" />
        </td>
        <td style="width: 150px">
            Notes:<br />
            <asp:TextBox ID="txtNotes" runat="server" Width="140" />
        </td>
       
        
        <td style="width: 150px">
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Insert" />
        </td>
    </tr>
</table>
                <asp:Label ID="lblresult" runat="server"></asp:Label>  
            </div>  
        </form>  
    </body>  
  
    </html>  
