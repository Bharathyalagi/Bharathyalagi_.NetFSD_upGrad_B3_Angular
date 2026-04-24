export function formatName(name) {
    return name.toUpperCase();
}
export function calculateAverage(students) {
    let total = 0;
    for (let s of students) {
        total += s.marks;
    }
    return total / students.length;
}
