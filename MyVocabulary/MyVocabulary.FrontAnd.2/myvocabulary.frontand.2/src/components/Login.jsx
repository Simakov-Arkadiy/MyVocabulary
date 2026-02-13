import React from 'react';
import LoginLabel from './LoginLabel.jsx';
function Login() {
   
    return (
        <div>
        <form name="loginForm" method="get" action="/authorization">
        <fieldset>
                    <legend>Авторизация</legend>
                    <p><LoginLabel forName ="login" text="логин"  /><input type="text" id="login" /></p>
                    <p><LoginLabel forName="password" text="пароль" /><input type="password" id="password"/></p>
        </fieldset>
        <p><input type="submit" value="авторизоваться"/></p>
        </form>
            <div><input type="submit" value="зарегистрироваться"/></div>
    </div>
    )
}

export default Login;