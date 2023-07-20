const xhr = new XMLHttpRequest();

xhr.open("GET", "https://localhost:7263/Company");

xhr.addEventListener("load", function () {
    if (xhr.status >= 200 && xhr.status < 400) {
        // Success!
        const obj = JSON.parse(xhr.response)
        console.log(obj[0].id);
        var result = "";
        for (var i = 0; i < obj.length; i++) {
            result += "<tr >" + "<td  align='left'  style='border-right: 1px solid gray'><a href=" + "https://localhost:7284/Home/Details/" + obj[i].id + ">" + obj[i].companyName + "</a>" + "</td>" + "<td  align='left' style='border-right: 1px solid gray'>" + obj[i].city + "</td>" + "<td align='left' style='border-right: 1px solid gray'>" + obj[i].state + "</td>" + "<td align='left' style='border-right: 1px solid gray'>" + obj[i].phone + "</td>" + "</tr>"; 
        }
        document.getElementById('grids').innerHTML = result;
       
    } else {
        alert("");
    }
});


xhr.send();
