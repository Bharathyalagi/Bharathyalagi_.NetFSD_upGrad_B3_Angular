export function getGrade(marks) {
    if (marks >= 80)
        return "A";
    if (marks >= 60)
        return "B";
    if (marks >= 40)
        return "C";
    return "Fail";
}
export function getTopper(students) {
    let top = students[0];
    for (let s of students) {
        if (s.marks > top.marks) {
            top = s;
        }
    }
    return top;
}
