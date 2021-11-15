import React, { useEffect, useState } from 'react'

const Contactos = () => {

    const [articulos, setArticulos] = useState([]);

    const urlAPI = 'https://localhost:44314/api/Articulos';

    useEffect(() => {
        fetch(urlAPI)
            .then(response => response.json())
            .then(data => {
                setArticulos([
                    ...articulos,
                    ...data
                ]);
            });
            // eslint-disable-next-line
    }, []);

    return (
        <>
            {articulos.map(({ id, nombre, descripcion, precio }) => (
                <div key={id} className="card mb-2" style={{ width: "18rem" }}>
                    <div className="card-body">
                        <h5 className="card-title">{`${id}. ${nombre}`}</h5>
                        <p className="card-text">{`${descripcion}`}</p>
                        <p className="card-text">{`${precio}`}</p>
                    </div>
                </div>))}
        </>
    )
}

export default Contactos
