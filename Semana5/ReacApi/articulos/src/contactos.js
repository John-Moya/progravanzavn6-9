import React from 'react'
import styles from '. /Cards.module.css';

    const Contacts = ({ contacts }) => {
      return (
        <div>
          <center><h1>Contact List</h1></center>
          {contacts.map((contact) => (
            <div className={styles.card}>
              <div className="card-body">
                <h5 class="card-title">{contact.name}</h5>
                <h6 class="card-subtitle mb-2 text-muted">{contact.email}</h6>
                <p class="card-text">{contact.company.catchPhrase}</p>
              </div>
            </div>
          ))}
        </div>
      )
    };
    export default Contacts