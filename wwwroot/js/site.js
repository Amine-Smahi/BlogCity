document.querySelector('#txtSearch').addEventListener('keypress', function (e) {
    var key = e.which || e.keyCode;
    if (key === 13) { // 13 is enter
        console.log("called");
        var searchText = document.querySelector('#txtSearch').value;
        window.location.replace("https://localhost:5001/" + searchText);
    }
});