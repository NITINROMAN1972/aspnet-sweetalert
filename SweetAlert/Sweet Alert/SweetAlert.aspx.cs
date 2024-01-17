using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sweet_Alert_SweetAlert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }

    // javascript alert
    protected void JS_Alert_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('JavaScript Alert!');", true);
    }

    // sweet alert question
    protected void SA_Question_Click(object sender, EventArgs e)
    {
        string title = "No data found !";
        string message = "Please check your query";
        string icon = "question";
        string confirmButtonText = "OK";

        string sweetAlertScript =
        $@"<script>
            Swal.fire({{ 
                title: '{title}', 
                text: '{message}', 
                icon: '{icon}', 
                confirmButtonText: '{confirmButtonText}'
            }});
        </script>";
        ClientScript.RegisterStartupScript(this.GetType(), "sweetAlert", sweetAlertScript, false);
    }

    // sweet info question
    protected void SA_Info_Click(object sender, EventArgs e)
    {
        string title = "Matched!";
        string message = "Selected data matched";
        string icon = "info";
        string confirmButtonText = "OK";

        string sweetAlertScript =
        $@"<script>
            Swal.fire({{ 
                title: '{title}', 
                text: '{message}', 
                icon: '{icon}', 
                confirmButtonText: '{confirmButtonText}'
            }});
        </script>";
        ClientScript.RegisterStartupScript(this.GetType(), "sweetAlert", sweetAlertScript, false);
    }

    // sweet alert success only
    protected void SA_Success_Only_Click(object sender, EventArgs e)
    {
        string title = "Success!";
        string message = "Saved successfully!";
        string icon = "success";
        string confirmButtonText = "OK";

        string sweetAlertScript =
        $@"<script>
            Swal.fire({{ 
                title: '{title}', 
                text: '{message}', 
                icon: '{icon}', 
                confirmButtonText: '{confirmButtonText}'
            }});
        </script>";
        ClientScript.RegisterStartupScript(this.GetType(), "sweetAlert", sweetAlertScript, false);
    }

    // sweet alert error only
    protected void SA_Error_Only_Click(object sender, EventArgs e)
    {
        string title = "Oops!";
        string message = "Please check again!";
        string icon = "error";
        string confirmButtonText = "OK";

        string sweetAlertScript =
        $@"<script>
            Swal.fire({{ 
                title: '{title}', 
                text: '{message}', 
                icon: '{icon}', 
                confirmButtonText: '{confirmButtonText}'
            }});
        </script>";
        ClientScript.RegisterStartupScript(this.GetType(), "sweetAlert", sweetAlertScript, false);
    }

    // sweet alert error only block
    protected void SA_Error_BGblock_Click(object sender, EventArgs e)
    {
        string title = "Oops!";
        string message = "Please check again!";
        string icon = "error";
        string confirmButtonText = "OK";
        string allowOutsideClick = "false"; // Prevent closing on outside click

        string sweetAlertScript =
        $@"<script>
            Swal.fire({{ 
                title: '{title}', 
                text: '{message}', 
                icon: '{icon}', 
                confirmButtonText: '{confirmButtonText}', 
                allowOutsideClick: {allowOutsideClick}
            }});
        </script>";
        ClientScript.RegisterStartupScript(this.GetType(), "sweetAlert", sweetAlertScript, false);
    }

    //------------------============{ Sweet Alert Redirect }============------------------

    // sweet alert success & redirect
    protected void SA_Success_Redirect_Click(object sender, EventArgs e)
    {
        string title = "Saved!";
        string message = "Record saved successfully!";
        string icon = "success";
        string confirmButtonText = "OK";
        string redirectUrl = "https://www.google.com";

        string sweetAlertScript =
            $@"<script>
                Swal.fire({{ 
                    title: '{title}', 
                    text: '{message}', 
                    icon: '{icon}', 
                    confirmButtonText: '{confirmButtonText}' 
                }}).then((result) => {{
                    if (result.isConfirmed) {{
                        window.location.href = '{redirectUrl}';
                    }}
                }});
            </script>";
        ClientScript.RegisterStartupScript(this.GetType(), "sweetAlert", sweetAlertScript, false);
    }

    // sweet alert - success redirect block
    protected void SA_Success_Redirect_BGblock_Click(object sender, EventArgs e)
    {
        string title = "Saved!";
        string message = "Record saved successfully!";
        string icon = "success";
        string confirmButtonText = "OK";
        string allowOutsideClick = "false"; // Prevent closing on outside click
        string redirectUrl = "https://www.google.com";

        string sweetAlertScript =
        $@"<script>
            Swal.fire({{ 
                title: '{title}', 
                text: '{message}', 
                icon: '{icon}', 
                confirmButtonText: '{confirmButtonText}', 
                allowOutsideClick: {allowOutsideClick}
            }}).then((result) => {{
                if (result.isConfirmed) {{
                    window.location.href = '{redirectUrl}';
                }}
            }});
        </script>";
        ClientScript.RegisterStartupScript(this.GetType(), "sweetAlert", sweetAlertScript, false);
    }

    //------------------============{ Sweet Alert Advnce }============------------------

    // sweet alert custom html, button and link
    protected void SA_Custom_Html_Link_Click(object sender, EventArgs e)
    {
        string title = "HTML example";
        string icon = "info";
        string htmlContent = @"You can use <b>bold text</b>,<a href='#'>links</a>,and other HTML tags";
        bool showCloseButton = true;
        bool showCancelButton = true;
        bool focusConfirm = false;
        string confirmButtonText = "<i class='fa fa-thumbs-up'></i> Great!";
        string confirmButtonAriaLabel = "Thumbs up, great!";
        string cancelButtonText = "<i class='fa fa-thumbs-down'></i>";
        string cancelButtonAriaLabel = "Thumbs down";

        string sweetAlertScript = $@"
        <script>
            Swal.fire({{
                title: '{title}',
                icon: '{icon}',
                html: `{htmlContent}`,
                showCloseButton: {showCloseButton.ToString().ToLower()},
                showCancelButton: {showCancelButton.ToString().ToLower()},
                focusConfirm: {focusConfirm.ToString().ToLower()},
                confirmButtonText: `{confirmButtonText}`,
                confirmButtonAriaLabel: '{confirmButtonAriaLabel}',
                cancelButtonText: `{cancelButtonText}`,
                cancelButtonAriaLabel: '{cancelButtonAriaLabel}'
            }});
        </script>";
        ClientScript.RegisterStartupScript(this.GetType(), "sweetAlert", sweetAlertScript, false);

    }

    // sweet alert dialouge with three buttons
    protected void SA_Three_Buttons_Dialouge_Click(object sender, EventArgs e)
    {
        string title = "Do you want to save the changes?";
        bool showDenyButton = true;
        bool showCancelButton = true;
        string confirmButtonText = "Save";
        string denyButtonText = "Dont Save";

        string sweetAlertScript = $@"
        <script>
            Swal.fire({{
                title: '{title}',
                showDenyButton: {showDenyButton.ToString().ToLower()},
                showCancelButton: {showCancelButton.ToString().ToLower()},
                confirmButtonText: '{confirmButtonText}',
                denyButtonText: '{denyButtonText}'
            }}).then((result) => {{
                if (result.isConfirmed) {{
                    Swal.fire('Saved!', 'mssg', 'success');
                }} else if (result.isDenied) {{
                    Swal.fire('Changes are not saved', 'mssg', 'info');
                }}
            }});
        </script>";

        ClientScript.RegisterStartupScript(this.GetType(), "sweetAlert", sweetAlertScript, false);

    }
}