import {
    addTaskCallback,
    listTasksCallback,
    addTaskPromise,
    listTasksPromise,
    deleteTaskPromise
} from "./script.js"

const input = document.getElementById("taskInput")
const list = document.getElementById("taskList")

const renderTasks = tasks => {
    let str = ""
    tasks.forEach((task, index) => {
        str += `<li>${task} <button onclick="removeTask(${index})">Delete</button></li>`
    })
    list.innerHTML = str
}

window.addNewTask = async () => {
    const value = input.value.trim()
    if (!value) return
    await addTaskPromise(value)
    const updated = await listTasksPromise()
    renderTasks(updated)
    input.value = ""
}

window.showTasks = async () => {
    const allTasks = await listTasksPromise()
    renderTasks(allTasks)
}

window.removeTask = async index => {
    await deleteTaskPromise(index)
    const updated = await listTasksPromise()
    renderTasks(updated)
}