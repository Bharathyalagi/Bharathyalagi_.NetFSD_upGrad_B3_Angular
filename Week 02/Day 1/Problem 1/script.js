window.onload = function () {
    let savedNote = localStorage.getItem("dailyNote");
    if (savedNote !== null) {
        document.getElementById("noteArea").value = savedNote;
    }
};

function saveNote() {
    let note = document.getElementById("noteArea").value;
    localStorage.setItem("dailyNote", note);
    alert("Note Saved Successfully");
}

function clearNote() {
    localStorage.removeItem("dailyNote");
    document.getElementById("noteArea").value = "";
    alert("Note Cleared");
}