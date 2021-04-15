interface Person {
    name: string;
    age: number;
}

function greet(person: Person) {
    return "Hello " + person.age;
}

let p: Person = {
    name: "Teppo",
    age: 33
};
