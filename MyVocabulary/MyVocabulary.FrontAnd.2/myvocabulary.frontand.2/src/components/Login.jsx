import React from 'react';
import LoginInput from './LoginInput.jsx';
import { useState } from 'react'

function Login() {

    const [loginInputs, setloginInput] = useState([
        {ID: 1, text: 'логин', type: 'text', id: 'login' },
        {ID: 2, text: 'пароль', type: 'password', id: 'password' }])

    const registration = (e) => {
        e.preventDefault
        const newInput = {
            ID: Date.now(),
            text: 'повторить пароль',
            type: 'password',
            id: 'password'
        }
        setloginInput([...loginInputs, newInput])
    }
    
    return (
        <div>
        <form name="loginForm" method="get" action="/authorization">
        <fieldset>
                    <legend>Авторизация</legend>
                    {loginInputs.map((loginInput) => (<LoginInput text={loginInput.text} type={loginInput.type} id={loginInput.id} key={loginInput.ID} />))}
        </fieldset>
        <p><input type="submit" value="авторизоваться"/></p>
            </form>
            <div><input onClick={registration} type="submit" value="зарегистрироваться" /></div>
    </div>
    )
}

export default Login; 