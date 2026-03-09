import React from 'react';
import Login from './Login.jsx'
import RegisterPanel from './RegisterPanel.jsx';
import { useState } from 'react'

function HomePanel() {
    var HomePanel = {
        position: 'absolute',
        margin: '0px',
        padding: '0px',
        left: '50%',
        top: '30%',
        transform: 'translate(-50%,-50%)',
        height: '20%',
        backgroundColor: 'rgba(199, 244, 250)',
        border: '3px solid rgba(222, 195,204)'
    };
    const [newForm, setNewForm] = useState({ login: "", password:"", repeatPassword:"" });

    function handleChange(e) {
        const { name, value } = e.target;
        setNewForm((newForm) => ({ ...newForm, [name]: value }));
        console.log(newForm);
    }

    const registerButton = (enteredLogin, enteredPassword, enteredRepeatPassword) => {
        if (enteredPassword == enteredRepeatPassword) {
            let personObject = {
                Login: `${enteredLogin}`,
                Password: `${enteredPassword}`
            }
            fetch('http://localhost:5167/Registration/Register', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(personObject)
            })
        }
        else {
            alert("пароль и повтор пароля не совпадают");
        }
        
    }

    
    const [currentPage, setCurrentPage] = useState('login');
    if (currentPage === 'login')
    {
        return (<div style={HomePanel}>
            <Login registerBattonCallBack={setCurrentPage} />
        </div>);
    }
    if (currentPage === 'register') {
        return (<div style={HomePanel}>
            <RegisterPanel registerBattonCallBack={registerButton} newForm={newForm} setNewForm={setNewForm} handleChange={handleChange} />
        </div>);
    }
}

export default HomePanel;