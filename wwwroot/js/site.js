var elements = document.querySelectorAll(".card");

function changeContent(FieldName) {
    // filtering the Job Offers by id
    elements.forEach(function (item) {
        if (item.id == FieldName) {
            item.style.display = "block";
        } else {
            item.style.display = "none";
        }
    });

    // activating the filter button chosen
    var button = document.querySelectorAll(".filterbtn");
    button.forEach(function (btn) {
        if (btn.name == `${FieldName}Button`) {
            btn.classList.add("active");
        } else {
            btn.classList.remove("active");
        }
    });
}
