export const get = async(url) => {
    fetch(url)
    .then(res => res.json())
    .then((data) => {
        console.log(data);
        return data;
    })
    .catch((err) => {
        console.log(err);
    });
}

export const post = async(url, payload) => {
    fetch(url, {
        method: "POST",
        mode:"cors",
        body: JSON.stringify(payload),
        headers: {
            "Content-type": "application/json; charset=UTF-8"
        }
    }).then((res) => {
        res.json();
    }).then((response) => {
        console.log(response);
    }).catch((err) => {
        console.log(err);
    });
}

export const put = async(url, payload) => {
    fetch(url, {
        method: "PUT",
        mode:"cors",
        body: JSON.stringify(payload),
        headers: {
            "Content-type": "application/json; charset=UTF-8"
        }
    }).then((res) => {
        res.json();
    }).then((response) => {
        console.log(response);
    }).catch((err) => {
        console.log(err);
    });
}

export const del = async(url, payload) => {
    fetch(url, {
        method: "DELETE",
        mode:"cors",
        body: JSON.stringify(payload),
        headers: {
            "Content-type": "application/json; charset=UTF-8"
        }
    }).then((res) => {
        res.json();
    }).then((response) => {
        console.log(response);
    }).catch((err) => {
        console.log(err);
    });
}