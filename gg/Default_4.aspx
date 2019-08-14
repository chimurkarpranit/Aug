<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_4.aspx.cs" Inherits="Day_2_4.Default_4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderWidth="1px" CellPadding="3" GridLines="Vertical" BorderStyle="None">
                <AlternatingRowStyle BackColor="#DCDCDC" />
               
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" ForeColor="White" Font-Bold="True" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
                <Columns>
							<asp:HyperLinkField
								DataNavigateUrlFields="EmployeeID"
								DataNavigateUrlFormatString="EmployeeTerritories.aspx?EmployeeID={0}"
								DataTextField="FirstName"
								HeaderText="FirstName"
								>
								
						   </asp:HyperLinkField>
                     <asp:TemplateField ItemStyle-Width="150px" HeaderText="LastName" SortExpression="LastName">
            <ItemTemplate>
                <%# Eval("LastName")%>
            </ItemTemplate>

<ItemStyle Width="150px"></ItemStyle>
        </asp:TemplateField>
        <asp:TemplateField ItemStyle-Width="150px" HeaderText="Address" SortExpression="Address">
            <ItemTemplate>
                <%# Eval("Address")%>
            </ItemTemplate>

<ItemStyle Width="150px"></ItemStyle>
        </asp:TemplateField>
        <asp:TemplateField ItemStyle-Width="150px" HeaderText="Salary" SortExpression="Salary">
            <ItemTemplate>
                <%# Eval("Salary")%>
            </ItemTemplate>

<ItemStyle Width="150px"></ItemStyle>
        </asp:TemplateField> 
                    </Columns>
               
              
            </asp:GridView>
              
               
                
        </div>
    </form>
</body>
</html>
