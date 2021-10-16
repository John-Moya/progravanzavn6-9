import React, { useEffect, useState } from 'react'
import Boton from './Boton'
import Input from './Inputs'

const FormularioArticulos = () => {
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

    const [formulario, setFormulario] = useState({
        name: '',
        desc: '',
        prec: '',
        id: ''
    });

    const handleChange = ({ target }) => {
        setFormulario({
            ...formulario,
            [target.name]: target.value
        });
    }

    const reset = () => {
        setFormulario({
            name: '',
            desc: '',
            prec: '',
            id: ''
        });
    }

    const handleSubmit = e => {
        e.preventDefault();
        fetch(urlAPI, requestOptions);
        reset();
        setArticulos([
            ...articulos
        ]);
    }

    const handleSubmitDelete = e => {
        e.preventDefault();
        fetch(urlAPI + "/" + id, requestOptionsDelete);
        reset();
    }

    const handleSubmitUpdate = e => {
        e.preventDefault();
        fetch(urlAPI + "/" + id, requestOptionsUpdate);
        reset();
    }

    const { name, desc, prec, id } = formulario;

    const requestOptions = {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            nombre: name,
            descripcion: desc,
            precio: prec,
        })
    };

    const requestOptionsDelete = {
        method: 'DELETE'
    };

    const requestOptionsUpdate = {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            id: id,
            nombre: name,
            descripcion: desc,
            precio: prec,
        })
    };

    return (
        <>
            {articulos.map(({ id, nombre, descripcion, precio }) => (
                <div key={id} className="card mb-2" style={{ width: "18rem" }}>
                    <div className="card-body">
                        <h5 className="card-title">{`${id}. ${nombre}`}</h5>
                        <p className="card-text">{`${descripcion}`}</p>
                        <p className="card-text">{`${precio}`}</p>
                    </div>
                </div>))
            }
            <form onSubmit={handleSubmit}>
                <div className='container d-flex justify-content-center'>
                    <div className="col-4">
                        <Input className="form-control mb-3" name="id" value={id} onChange={handleChange} placeholder='ID Para update y delete' />
                        <Input className="form-control mb-3" name="name" value={name} onChange={handleChange} placeholder='Nombre' />
                        <Input className="form-control mb-3" name="desc" value={desc} onChange={handleChange} placeholder='Descripción' />
                        <Input className="form-control mb-3" name="prec" value={prec} onChange={handleChange} placeholder='Precio' />
                        <Boton label="Agregar" type='submit' className='btn btn-primary mb-3' />
                    </div>
                </div>
            </form>
            <form onSubmit={handleSubmitDelete}>
                <div className='container d-flex justify-content-center'>
                    <div className="col-4">
                        <Boton label="Eliminar" type='submit' className='btn btn-danger' />
                    </div>
                </div>
            </form>
            <form onSubmit={handleSubmitUpdate}>
                <Boton label="Actualizar" type='submit' className='btn btn-success mt-3' />
            </form>
        </>
    )
}

export default FormularioArticulos
