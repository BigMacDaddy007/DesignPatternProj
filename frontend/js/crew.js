let crew = [];
let crewTotal = document.getElementById('total');
const launchBtn = document.getElementById('launch');
const cancelBtn = document.getElementById('cancel');

const table = document.getElementById("table-body");

const populate = (data) => {
    data.forEach((element, index) => {
        table.innerHTML += row(element, index);
    });

    const buttons = document.getElementsByClassName("hire-btn");
    for(let i = 0; i < buttons.length; i++){
        buttons[i].addEventListener('click', () => hire(i));
    }
}

const row = (obj, index) => {
    return `
        <tr class="t-row">
        <td>${obj.name}</th>
        <td>${obj.type}</td>
        <td id="stats-${index}">${displayStats(obj)}</td>
        <td id="btn-${index}">
        <button value="${index}" type="button" class="btn btn-success hire-btn">Hire</button>
        </td>
        </tr>
    `;
}

const hire = (value) => {
    if(crew.length < 5) {
        crew = [...crew, dataObj[value]];
        const target = document.getElementById(`btn-${value}`);
        target.innerHTML = `<button value="${value}" type="button" class="btn btn-danger hire-btn">Cancel</button>`;
        target.firstChild.addEventListener('click', () => unhire(value));
        displayCrew();
    }
}

const unhire = (value) => {
    if(crew.length > 0) {
        crew = crew.filter(obj => obj.id != value);
        const target = document.getElementById(`btn-${value}`);
        target.innerHTML = `<button value="${value}" type="button" class="btn btn-success hire-btn">Hire</button>`;
        target.firstChild.addEventListener('click', () => hire(value));
        displayCrew();
    }
}

const displayCrew = () => {
 crewTotal.innerHTML = `
    <h3 id="total">Total Crew: ${crew.length}/5</h3>
 `;
}

const displayStats = (obj) => {
    let stats = {
        Attack: obj["attack"],
        Health: obj["health"],
        Shields: obj["shields"],
        ShieldRegen: obj["shieldRegen"],
        Speed: obj["speed"]
    }

    let result = ``;
    for(const key in stats){
        if(stats[key] > 0){
            result += `${key} +${stats[key]} `;
        }
    }
    return result;
}

const launch = () => {
    window.location.href = '/map.html';
}

const cancel = () => {
    window.location.href = '/';
}

launchBtn.addEventListener('click', () => launch());
cancelBtn.addEventListener('click', () => cancel());

document.addEventListener('DOMContentLoaded', async () => {
    let dataJson = await fetch("https://starshipapi20210617150221.azurewebsites.net/api/Crewmates")
    .then(res => res.json())
    .then((data) => {
        return data;
    })
    .catch((err) => {
        console.log(err);
    });

    populate(dataJson);
});