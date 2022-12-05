<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GardenInterface._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
  <div class="container">
    
       <div class="col-md-4 col-md-offset-4">
           <h1>Product</h1>
       </div>
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="ID:"></asp:Label>
                    <asp:TextBox ID="ID" runat="server" Enabled="true" CssClass="form-control input-sm"></asp:TextBox>
                 </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
                    <asp:TextBox ID="name" runat="server" Enabled="true" CssClass="form-control input-sm"></asp:TextBox>
                 </div>
            </div>
        </div>
        <div class="row">
         <div class="col-md-4 col-md-offset-1">
                        <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Price:"></asp:Label>
                            <br />
                            <asp:TextBox ID="price" runat="server" Enabled="true" CssClass="form-control input-sm"></asp:TextBox><asp:Label runat="server" Text="" ForeColor="Red" Font-Bold="true" ID="lbmsg"></asp:Label>
                        </div>
                    </div> 
        </div>
            

       
            <div class="row">
                <div class="col-md col-md-offset-1">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-success" Width="60px" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-primary" Style="border: solid 1px" Width="60px" OnClick="btnEdit_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" Width="65px" OnClick="btnDelete_Click" />
                    <asp:Button ID="btnFind" runat="server" Text="Search By ID" CssClass="btn btn-info" Width="105px" OnClick="btnFind_Click" />
                    <asp:Button ID="btnAll" runat="server" Text="All Products" CssClass="btn btn-info" Width="100px" OnClick="btnAll_Click" />
                    </div>

            </div>
            </div> 
    <div class="container">
    
      
        <div class="col-md-4 col-md-offset-1">
               <table class="style3">  
        <tr>  
            <td>  
                <asp:Label ID="lblResult" runat="server" ForeColor="Red" />  
                <br />  
                <br />  
                <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan"  
                    BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Style="text-align: left"  
                    Width="304px">  
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />  
                    <FooterStyle BackColor="Tan" />  
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />  
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />  
                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />  
                    <SortedAscendingCellStyle BackColor="#FAFAE7" />  
                    <SortedAscendingHeaderStyle BackColor="#DAC09E" />  
                    <SortedDescendingCellStyle BackColor="#E1DB9C" />  
                    <SortedDescendingHeaderStyle BackColor="#C2A47B" />  
                </asp:GridView>  
            </td>  
        </tr>  
    </table> 

        </div>
         <div class="col-md-4 col-md-offset-1">
             <asp:Label ID="Label4" runat="server" Text="Search Result:"></asp:Label><br />
             <asp:Label ID="searchID" runat="server" Text=""></asp:Label><br />
             <asp:Label ID="searchName" runat="server" Text=""></asp:Label><br />
             <asp:Label ID="searchPrice" runat="server" Text=""></asp:Label>
         </div>

    </div>

       
   

    
</asp:Content>