const xhr = new XMLHttpRequest();

xhr.open("GET", "https://localhost:7263/Company/" + document.getElementById('idcompany').value);

xhr.addEventListener("load", function () {
    if (xhr.status >= 200 && xhr.status < 400) {
        // Success!
        const obj = JSON.parse(xhr.response)
        console.log(obj);
        var histories = "";
        var notes = "";
        var employees = "";
        document.getElementById("id").value = obj.id;
        document.getElementById("name").value = obj.name;
        document.getElementById("address").value = obj.address;
        document.getElementById("city").value = obj.city;
        document.getElementById("state").value = obj.state;
        for (var i = 0; i < obj.histories.length; i++) {
            histories += "<tr >" + "<td  align='left'  style='border-right: 1px solid gray'>" + obj.histories[i].orderDate + "</td>" + "<td  align='left' style='border-right: 1px solid gray'>" + obj.histories[i].storeCity + "</td>"  + "</tr>";
        }
        for (var i = 0; i < obj.notes.length; i++) {
            notes += "<tr >" + "<td  align='left'  style='border-right: 1px solid gray'>" + obj.notes[i].invoiceNumber + "</td>" + "<td  align='left' style='border-right: 1px solid gray'>" + obj.notes[i].employe.firstName +" "+ obj.notes[i].employe.lastName + "</td>" + "</tr>";
        }
        for (var i = 0; i < obj.employees.length; i++) {
            employees += "<tr >" + "<td  align='left'  style='border-right: 1px solid gray'>" + obj.employees[i].firstName + "</td>" + "<td  align='left' style='border-right: 1px solid gray'>" + obj.employees[i].lastName + "</td>" + "</tr>";
        }
        document.getElementById('firstname').value = obj.employees[0].firstName;
        document.getElementById('lastname').value = obj.employees[0].lastName;
        document.getElementById('title').value = obj.employees[0].title;
        document.getElementById('birthdate').value = obj.employees[0].birthDate;
        document.getElementById('position').value = obj.employees[0].position;

        document.getElementById('gridshistories').innerHTML = histories;
        document.getElementById('gridsnotes').innerHTML = notes;
        document.getElementById('gridsemployees').innerHTML = employees;

    } else {
        alert("dd");
    }
});


xhr.send();