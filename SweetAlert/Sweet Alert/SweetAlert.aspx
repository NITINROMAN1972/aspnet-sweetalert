<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SweetAlert.aspx.cs" Inherits="Sweet_Alert_SweetAlert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sweet Alert</title>

    <!--Bootstrap CSS-->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!--Bootstrap JS-->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    <!--jQuery-->
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>


    <!-- FontAwesome CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" />

    <!-- SweetAlert2 CSS -->
    <link href="https://cdn.jsdelivr.net/npm/sweetalert2@11.10.3/dist/sweetalert2.min.css" rel="stylesheet" />
    <!-- SweetAlert2 JS -->
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11.10.3/dist/sweetalert2.all.min.js"></script>
    <!-- https://sweetalert2.github.io/# -->

</head>
<body>
    <form id="form1" runat="server">

        <!-- Sweet Alert  -->
        <div class="card col-md-6 mx-auto mt-5 py-2 border border-secondary-subtle rounded-2 shadow">
            <label class="text-center">Sweet Alert</label>
            <div class="card-body text-center">
                <asp:Button ID="JS_Alert" runat="server" Text="JavaScript Alert" OnClick="JS_Alert_Click" CssClass="btn btn-secondary col-md-5" />
            </div>
            <div class="card-body text-center">
                <asp:Button ID="SA_Question" runat="server" Text="Question ?" OnClick="SA_Question_Click" CssClass="btn btn-white border border-secondary-subtle col-md-5" />
            </div>
            <div class="card-body text-center">
                <asp:Button ID="SA_Info" runat="server" Text="Information !" OnClick="SA_Info_Click" CssClass="btn btn-info col-md-5" />
            </div>
            <div class="card-body text-center">
                <asp:Button ID="SA_Success_Only" runat="server" Text="Success only" OnClick="SA_Success_Only_Click" CssClass="btn btn-success col-md-5" />
            </div>
            <div class="card-body text-center">
                <asp:Button ID="SA_Error_Only" runat="server" Text="Error only" OnClick="SA_Error_Only_Click" CssClass="btn btn-danger col-md-5" />
            </div>
            <div class="card-body text-center">
                <asp:Button ID="SA_Error_BGblock" runat="server" Text="Error only & BG block" OnClick="SA_Error_BGblock_Click" CssClass="btn btn-danger col-md-5" />
            </div>
        </div>

        <!-- Sweet Alert Redirect  -->
        <div class="card col-md-6 mx-auto mt-2 py-2 border border-secondary-subtle rounded-2 shadow">
            <label class="text-center">Sweet Alert Redirect</label>
            <div class="card-body text-center">
                <asp:Button ID="SA_Success_Redirect" runat="server" Text="Success with redirect" OnClick="SA_Success_Redirect_Click" CssClass="btn btn-success col-md-5" />
            </div>
            <div class="card-body text-center">
                <asp:Button ID="SA_Success_Redirect_BGblock" runat="server" Text="Success with redirect & BG block" OnClick="SA_Success_Redirect_BGblock_Click" CssClass="btn btn-success col-md-5" />
            </div>
        </div>

        <!-- Sweet Alert Advance  -->
        <div class="card col-md-6 mx-auto mt-2 py-2 border border-secondary-subtle rounded-2 shadow">
            <label class="text-center">Sweet Alert Advance</label>
            <div class="card-body text-center">
                <asp:Button ID="SA_Custom_Html_Link" runat="server" Text="HTML, Icons, Links" OnClick="SA_Custom_Html_Link_Click" CssClass="btn btn-success col-md-5" />
            </div>
            <div class="card-body text-center">
                <asp:Button ID="SA_Three_Buttons_Dialouge" runat="server" Text="3 Button Dialouge" OnClick="SA_Three_Buttons_Dialouge_Click" CssClass="btn btn-warning col-md-5" />
            </div>
        </div>
    </form>
</body>
</html>
