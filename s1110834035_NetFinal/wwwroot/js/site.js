// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function PreviewImage() {
    window.alert("sometext");
    var oFReader = new FileReader(); // HTML5 File API
    oFReader.readAsDataURL(document.getElementById("ImgF").files[0]);
    oFReader.onload = function (oFREvent) {
        document.getElementById("preview").src = oFREvent.target.result;
    };
};
// 載入圖片失敗時, 使用預設圖片
function imgUserAvatarError(image) {
    image.src = '@Url.Content("~/images/nothing.png")';
    return true;
}
