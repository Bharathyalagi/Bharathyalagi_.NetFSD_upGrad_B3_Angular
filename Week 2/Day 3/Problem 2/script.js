let tasks = []
export const addTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks.push(task)
        callback(tasks)
    }, 500)
}

export const listTasksCallback = callback => {
    setTimeout(() => {
        callback(tasks)
    }, 500)
}

export const deleteTaskCallback = (index, callback) => {
    setTimeout(() => {
        tasks.splice(index, 1)
        callback(tasks)
    }, 500)
}

export const addTaskPromise = task => {
    return new Promise(resolve => {
        setTimeout(() => {
            tasks.push(task)
            resolve(tasks)
        }, 500)
    })
}

export const listTasksPromise = () => {
    return new Promise(resolve => {
        setTimeout(() => {
            resolve(tasks)
        }, 500)
    })
}

export const deleteTaskPromise = index => {
    return new Promise(resolve => {
        setTimeout(() => {
            tasks.splice(index, 1)
            resolve(tasks)
        }, 500)
    })
}