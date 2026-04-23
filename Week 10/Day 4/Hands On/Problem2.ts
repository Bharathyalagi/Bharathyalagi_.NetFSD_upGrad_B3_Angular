function getWelcomeMessage(name: string): string {
    return `Welcome ${name}`;
}

function getUserInfo(name: string, age?: number): string {
    if (age !== undefined) {
        return `${name} is ${age} years old`;
    }
    return `${name} details not complete`;
}

function getSubscriptionStatus(name: string, isSubscribed: boolean = false): string {
    return isSubscribed ? `${name} is subscribed` : `${name} is not subscribed`;
}

function isEligibleForPremium(age: number): boolean {
    return age > 18;
}

const greet = (name: string): string => {
    return `Hello ${name}`;
};

const NotificationService = {
    appName: "NotifyApp",
    showMessage: (user: string) => {
        return `Welcome to ${NotificationService.appName}, ${user}`;
    }
};

console.log(getWelcomeMessage("Bharath"));
console.log(getUserInfo("Bhuvan", 23));
console.log(getUserInfo("Sushmita"));
console.log(getSubscriptionStatus("Bharath", true));
console.log(isEligibleForPremium(24));
console.log(greet("Bhuvan"));
console.log(NotificationService.showMessage("Sushmita"));