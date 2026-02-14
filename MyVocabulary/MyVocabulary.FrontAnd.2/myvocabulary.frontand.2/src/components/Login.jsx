import React from 'react';
import LoginInput from './LoginInput.jsx';
import { useState } from 'react'

function Login() {



    const registration = () => {
        console.log('регистрация!')
    }
    return (
        <div>
        <form name="loginForm" method="get" action="/authorization">
        <fieldset>
                    <legend>Авторизация</legend>
                    <LoginInput  text="логин" type="text" id="login" />
                    <LoginInput  text="пароль" type="password" id="password"/>
        </fieldset>
        <p><input type="submit" value="авторизоваться"/></p>
            </form>
            <div><input onClick={registration} type="submit" value="зарегистрироваться" /></div>
    </div>
    )
}

export default Login; 