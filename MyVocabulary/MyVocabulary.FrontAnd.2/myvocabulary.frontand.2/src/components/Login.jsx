import React from 'react';
import LoginInput from './LoginInput.jsx';

function Login(props) {

    const inputs = [
        { ID: 1, text: 'логин', type: 'text', id: 'login' },
        { ID: 2, text: 'пароль', type: 'password', id: 'password' }];
    
    return (
        <div>
        <form name="loginForm" method="get" action="/authorization">
        <fieldset>
                    <legend>Авторизация</legend>
                    {inputs.map((input) => (<LoginInput text={input.text} type={input.type} id={input.id} key={input.ID} />))}
        </fieldset>
        <p><input type="submit" value="авторизоваться"/></p>
            </form>
            <div><input onClick={() => { props.registerBattonCallBack('register') }} type="submit" value="зарегистрироваться" /></div>
    </div>
    )
}

export default Login; 