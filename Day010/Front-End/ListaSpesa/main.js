const title = document.createElement("h1");
const input = document.createElement("input");
const button = document.createElement("button");
title.textContent = "Lista della Spesa";
button.textContent = "INSERISCI";

document.body.appendChild(title);
document.body.appendChild(input);
document.body.appendChild(button);

const listaSpesa = document.createElement("ul");
document.body.appendChild(listaSpesa);

const createTask = (title) => {
  const task = document.createElement("li");
  task.textContent = title;
  listaSpesa.appendChild(task);
};

button.addEventListener("click", () => {
  fetch("https://jsonplaceholder.typicode.com/todos", {
    method: "POST",
    body: JSON.stringify({
      title: input.value,
      user: 1,
      complete: false,
    }),
  }).then((res) => {
    if (res.ok) {
      createTask(input.value);
    }
  });
});

fetch("https://jsonplaceholder.typicode.com/todos")
  .then((res) => res.json())
  .then((listS) => {
    for (const obj of listS.slice(0, 10)) {
      createTask(obj.title);
    }
  });
