const employees = [
    { id: 1, name: "Ravi", job: "Manager", salary: 80000 },
    { id: 2, name: "Priya", job: "Salesman", salary: 40000 },
    { id: 3, name: "Arjun", job: "Clerk", salary: 25000 },
    { id: 4, name: "Meena", job: "Manager", salary: 90000 },
    { id: 5, name: "Kiran", job: "Salesman", salary: 45000 }
];

const select = document.getElementById("jobSelect");
const button = document.getElementById("showBtn");
const tableBody = document.querySelector("#empTable tbody");

button.addEventListener("click", function () {

    const selectedJob = select.value;

    let filteredEmployees;

    if (selectedJob === "All") {
        filteredEmployees = employees;
    } else {
        filteredEmployees = employees.filter(function(emp) {
            return emp.job === selectedJob;
        });
    }

    tableBody.innerHTML = "";

    for (let i = 0; i < filteredEmployees.length; i++) {
        const row = `
            <tr>
                <td>${filteredEmployees[i].id}</td>
                <td>${filteredEmployees[i].name}</td>
                <td>${filteredEmployees[i].job}</td>
                <td>${filteredEmployees[i].salary}</td>
            </tr>
        `;
        tableBody.innerHTML += row;
    }
});