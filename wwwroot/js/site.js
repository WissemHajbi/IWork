var elements = document.querySelectorAll(".card");

function changeContent(FieldName) {
    elements.forEach(function (item) {
        if (item.id != FieldName) {
            item.style.display = "none";
            console.log(" 1 i " + item.id + " fieldname = " + FieldName);
        } else {
            item.style.display = "block";
            console.log(" 2 i " + item.id + " fieldname = " + FieldName);
        }
    });
}
