import React from 'react'

const Boton = ({ label, ...rest }) => {
    return (
        <button {...rest}>{label}</button>
    )
}

export default Boton
