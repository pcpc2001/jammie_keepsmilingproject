<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MediaSlider.ascx.cs" Inherits="MediaSlider" %>

<div>
    <div class="MediaSlider">
        
        
        <div id="MediaSliderFrame">
            <%= this.renderSliderElements("items")  %>
        </div>
        <div id="MediaSliderNavLeft" onclick="mediaSliderOnNavLeftClicked()">
            <div class="MediaSliderNavFrame">
                <p class="MediaSliderNavText">&lt;</p>
            </div>
        </div>
        <div id="MediaSliderNavRight" onclick="mediaSliderOnNavRightClicked()">
            <div class="MediaSliderNavFrame">
                <p class="MediaSliderNavText">&gt;</p>
            </div>
        </div>
        <script>
            setMediaCount('<%=this.getMediaElementCount()%>');
            setFirstSlideId('<%=this.getFirstSlideId()%>');
        </script>
    </div>
</div>