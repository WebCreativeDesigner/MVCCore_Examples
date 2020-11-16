function changePicture()
{
    var image = document.getElementById("MainPicture");
    var imagebtn = document.getElementById("Change Image");
    if (image.getAttribute('src') == "./Images/IT Clown.gif") {
        image.src = "./Images/Excel and Simpsons.jpg";
        imagebtn.innerHTML = "Change to Scary Picture!"
    }
    else {
        image.src = "./Images/IT Clown.gif";
        imagebtn.innerHTML = "Change to Nice Picture!"
    }
}