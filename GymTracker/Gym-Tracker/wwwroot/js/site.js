// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function displayGymDetails(id) {
    
    const response = await fetch(`https://localhost:7219/api/Gym/${id}`);
    const data = await response.json();
    document.getElementById('ID').innerHTML = data[0].id;
    document.getElementById('ID').style.visibility = "visible";
    document.getElementById('userName').innerHTML = data[0].name;
    document.getElementById('userName').style.visibility = "visible";
   

}

async function displaySearchResults(userId,userEmail) {
    const response = await fetch(`https://localhost:7219/api/Gym/${userID}&userEmail=${userEmail}`);
    const data = await response.json();
    var innerHtml = "";
    for (let i = 0; i < data.length; i++) {
        innerHtml += `<div style="card"><a href="https://localhost:7146/hotel?hotelid=${data[i].id}">${data[i].userName}</a></div>`
    }
    document.getElementById("hotelResults").innerHTML = innerHtml;
    document.getElementById('hotelResults').style.visibility = "visible";
}