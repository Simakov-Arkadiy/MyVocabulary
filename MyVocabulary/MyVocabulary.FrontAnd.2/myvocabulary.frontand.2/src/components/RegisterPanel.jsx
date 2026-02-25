import React from 'react';
import LoginInput from './LoginInput.jsx';
function RegisterPanel(props) {
    var RegisterPanel = {
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

    const inputs = [
        { ID: 1, text: 'логин', type: 'text', id: 'login' },
        { ID: 2, text: 'пароль', type: 'password', id: 'password' },
     { ID: 2, text: 'повторить пароль', type: 'password', id: 'password' }];

    return (<div>
        <form className="RegisterForm" onSubmit={props.registerButton} >
            <fieldset>
                <legend>Регистрация</legend>
                {inputs.map((input) => (<LoginInput text={input.text} type={input.type} id={input.id} key={input.ID} />))}
            </fieldset>
            <div><input type="submit" value="зарегистрироваться" /></div>
        </form>
    </div>)
}

export default RegisterPanel;