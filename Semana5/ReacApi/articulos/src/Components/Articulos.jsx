import React from 'react';
import styles from '. /Cards.module.css';





    const Articulos = ({ a }) => {
      return (
        <div>
          <center><h1>Lista De Articulos</h1></center>
          {a.map((contact) => (
            <div className ={styles.card}>
              <div className ={styles.card_body}>
                <h5 class="card-title">{a.Id}</h5>
                <h6 class="card-subtitle mb-2 text-muted">{a.Articulos}</h6>
                <p class="card-text">{a.Descripcion}</p>
              </div>
            </div>
          ))}
        </div>
      )
    };
    export default Articulos