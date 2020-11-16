function changePicture() {
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

function ShowHide() {
    var x = document.getElementById("divCalculationSummary");
    var y = document.getElementById("btnShowHide");
    if (x.style.display === "none") {
        x.style.display = "block";
        y.innerHTML = "Hide Calculation";
        y.innerText = "Hide Calculation";
    } else {
        x.style.display = "none";
        y.innerHTML = "Show Calculation";
        y.innerText = "Show Calculation";
    }
}

function ChangeDivBackground() {
    //$('.content').css("background-color", "green");

    var x = document.getElementById("divConfirmation");

    if (x.innerText === 'This is a Fibonacci Number') {
        $('.Confirmation').css("background-color", "green");
    }

    if (x.innerText === 'This is not a Fibonacci Number') {
        $('.Confirmation').css("background-color", "red")
    }

    if (x.innerText === '') {
        $('.Confirmation').css("background-color", "yellow")
    }
    
}