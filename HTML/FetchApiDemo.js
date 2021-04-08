const aktiivinenKäyttäjäId = 2;

console.log("Aloitetaan fetch-kutsun tekeminen...");
fetch('https://jsonplaceholder.typicode.com/todos/')
    .then(response => response.json())
    .then(json => {

        let html = "";
        for (let index = 0; index < json.length; index++) {
            const tehtävä = json[index];

            if (tehtävä.userId == aktiivinenKäyttäjäId) {
                html += "<p>" + tehtävä.title + "</p>\r\n";
            }
        }

        const div = document.getElementById("tehtävätDiv");
        div.innerHTML = html;
    });
