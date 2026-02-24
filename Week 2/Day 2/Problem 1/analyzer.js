const marks = [78, 85, 62, 90, 55];

const button = document.getElementById("analyzeBtn");
const resultDiv = document.getElementById("result");

button.addEventListener("click", function () {
    const total = marks.reduce((acc, mark) => acc + mark, 0);
    const average = total / marks.length;
    const result = average >= 60 ? "Pass" : "Fail";

    resultDiv.innerHTML = `
    <p>Marks: ${marks.join(", ")}</p>
    <p>Total Marks: ${total}</p>
    <p>Average Marks: ${average.toFixed(2)}</p>
    <p>Result: ${result}</p>
    `;
});

