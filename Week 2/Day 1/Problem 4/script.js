let db = openDatabase("ExpenseDB", "1.0", "Expense Database", 2 * 1024 * 1024);

db.transaction(function(tx) {
    tx.executeSql(
        "CREATE TABLE IF NOT EXISTS expenses (id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, amount REAL, date TEXT)"
    );
});

function addExpense() {
    let title = document.getElementById("title").value;
    let amount = document.getElementById("amount").value;
    let date = document.getElementById("date").value;

    db.transaction(function(tx) {
        tx.executeSql(
            "INSERT INTO expenses (title, amount, date) VALUES (?, ?, ?)",
            [title, amount, date]
        );
    });
}

function viewExpenses() {
    db.transaction(function(tx) {
        tx.executeSql(
            "SELECT * FROM expenses",
            [],
            function(tx, results) {
                let list = document.getElementById("expenseList");
                list.innerHTML = "";

                for (let i = 0; i < results.rows.length; i++) {
                    let row = results.rows.item(i);
                    let li = document.createElement("li");
                    li.textContent = row.id + " - " + row.title + " - " + row.amount + " - " + row.date;
                    list.appendChild(li);
                }
            }
        );
    });
}

function deleteExpense() {
    let id = prompt("Enter Expense ID to delete:");

    db.transaction(function(tx) {
        tx.executeSql(
            "DELETE FROM expenses WHERE id = ?",
            [id]
        );
    });
}