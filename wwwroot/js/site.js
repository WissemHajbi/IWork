var elements = document.querySelectorAll(".card");

function changeContent(FieldName) {
    var div = document.getElementById("container");
    var button = document.querySelectorAll(".filterbtn");
    // activating the filter button chosen
    button.forEach(function (btn) {
        if (btn.name == `${FieldName}Button`) {
            btn.classList.add("active");
        } else {
            btn.classList.remove("active");
        }
    });

    switch (FieldName) {
        case "All":
            elements.forEach(function (item) {
                item.style.display = "block";
            });
            div.classList.remove("row-cols-3");
            div.classList.add("row-cols-4");
            break;
        default:
            // filtering the Job Offers by id
            elements.forEach(function (item) {
                if (item.id == FieldName) {
                    item.style.display = "block";
                } else {
                    item.style.display = "none";
                }
            });

            div.classList.remove("row-cols-4");
            div.classList.add("row-cols-3");
            break;
    }
}

// description trim
var offers_card_desc = document.querySelectorAll(".OffersCardDesc");
offers_card_desc.forEach((el) => {
    if (el.textContent.length > 35) {
        el.textContent = el.textContent.slice(0, 35) + "...";
    }
});

// job offer description format
var desc = document.querySelector(".nbtext");
var t = desc.textContent;
var start = 0;
var counter = 1;
var tab = t.split(":");
tab.forEach((e) => {
    console.log(e);
    const lineBreak = document.createElement("br");
    if (counter++ == 1) {
        desc.textContent = e + " : ";
    } else {
        desc.innerHTML += e + " : ";
    }
    desc.appendChild(lineBreak);
    desc.innerHTML += e;
});

for (var i = 0; i < desc.textContent.length; i++) {
    if (desc.textContent[i] === ":") {
    }
}
