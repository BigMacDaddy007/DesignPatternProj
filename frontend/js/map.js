const locationList = document.getElementById('locations');
const cancelBtn = document.getElementById('cancel');

const dataObj = [
    {
        id:0,
        name:"Alderaan"
    },
    {
        id:1,
        name:"Alderaan"
    },
]

const populate = (data) => {
    data.forEach((element, index) => {
        locationList.innerHTML += row(element, index);
    });

    const buttons = document.getElementsByClassName('travel-btn');
    for(let i = 0; i < buttons.length; i++){
        buttons[i].addEventListener('click', () => travel(i));
    }
}

const row = (obj, index) => {
    return `
        <li class="list-group-item">${obj.name}
        <button value="${index}" type="button" class="float-right btn btn-success travel-btn">Travel</button>
        </li>
    `;
}

const travel = (index) => {
    window.location.href = "/encounter.html"
}

const cancel = () => {
    window.location.href = "/"
}

cancelBtn.addEventListener('click', () => cancel());

populate(dataObj);