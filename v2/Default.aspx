<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile="~/MainMaster.master" %>

<%@ Register Src="~/MediaSlider.ascx" TagPrefix="uc1" TagName="MediaSlider" %>
<%@ Register Src="~/MediaSlideImage.ascx" TagPrefix="uc1" TagName="MediaSlideImage" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Styles/DefaultPage.css" type="text/css" media="screen" />
    <script src="js/MediaSliderJs.js">
        init();
    </script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ClientIDMode="Static">
    <div>
        <uc1:MediaSlider runat="server" id="MediaSlider" class="Slider" ContentClass="ContentSlide" ClientIDMode="Inherit">
            <MediaSlideElements>
                <uc1:MediaSlideImage runat="server" class="MediaSlideImage" src="Images/test1.png" />
                <uc1:MediaSlideImage runat="server" class="MediaSlideImage" src="Images/test2.png" />
                <uc1:MediaSlideImage runat="server" class="MediaSlideImage" src="Images/test3.png" />
                <uc1:MediaSlideImage runat="server" class="MediaSlideImage" src="Images/test4.png" />
            </MediaSlideElements>           
        </uc1:MediaSlider>
    </div>
    Hello World
</asp:Content>
