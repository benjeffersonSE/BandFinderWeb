(function() {
    // Burgermenu, drop-down if in mobile mode to allow easeir navigation of pages
    $(".burgerMenu").on("click", function(ev) {
        ev.preventDefault();
        $(this).toggleClass("animateBurger");
        $(".mainNav").slideToggle("800");
    });
}
)();


// Password checking function, whitelists 
$('input').on('keypress', function(event) {
    var newInput = new RegExp("^[a-zA-Z0-9 !@$.?,+]"); // white listed characters

    var checkSymbl = String.fromCharCode(!event.charCode ? event.which : event.charCode);
    if (!newInput.test(checkSymbl))
    { 
        console.info("invalid character input");
        event.preventDefault();
        return false;
    }
});

//open drop down rows to
function OpenRows(clickedRow)//rows id passed in from database management.php
{
    var elements = document.querySelectorAll(".tableRowButton,.tableRow");

    for (var i = 0; i < elements.length; i++) { // FOR loop to go through the array of elements and hide toggled rows
        if (clickedRow == elements[i].id)
            elements.item(i).classList.toggle("hidden"); // IF row is clicked, hide classList
    }
}

function OpenRows2(clickedRow)//rows id passed in from database management.php
{
    var elements = document.querySelectorAll(".tableRowButton2,.tableRow2");

    for (var i = 0; i < elements.length; i++) { // FOR loop to go through the array of elements and hide toggled rows
        if (clickedRow == elements[i].id)
            elements.item(i).classList.toggle("hidden"); // IF row is clicked, hide classList
    }
}