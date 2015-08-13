<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MediaSlider.ascx.cs" Inherits="MediaSlider" %>

<div class="MediaSlider">
    <%= this.renderSliderElements("items")  %>
    <script>
        setMediaCount('<%=this.getMediaElementCount()%>');
    </script>
</div>