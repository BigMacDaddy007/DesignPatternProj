const encounterTxt = document.getElementById('encounter');

const dataObj = {
    description: "A giant space station appears to be firing on the planet!"
}

const populate = (data) => {
    encounterTxt.innerHTML = `<p>${data.description}</p>`;
}

populate(dataObj);