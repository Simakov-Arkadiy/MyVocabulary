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
        { ID: 1, text: 'логин', type: 'text', id: 'login', name: 'login' },
        { ID: 2, text: 'пароль', type: 'password', id: 'password', name: 'password' },
        { ID: 2, text: 'повторить пароль', type: 'password', id: 'password',  name: 'repeatPassword' }];

    const onSubmit = (e) => {
        e.preventDefault();
        props.registerBattonCallBack(props.newForm.login, props.newForm.password, props.newForm.repeatPassword);
    }

    return (<div>
        <form className="RegisterForm" onSubmit={onSubmit} >
            <fieldset>
                <legend>Регистрация</legend>
                {inputs.map((input) => (<LoginInput text={input.text} type={input.type} id={input.id} key={input.ID} value={props.newForm} onChange={props.handleChange} name={input.name} />))}
            </fieldset>
            <div><input type="submit" value="зарегистрироваться"/></div>
        </form>
    </div>)
}

export default RegisterPanel;