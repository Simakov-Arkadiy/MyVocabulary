import React from 'react';
import LoginLabel from './LoginLabel.jsx';
function LoginInput(props)
{
    
    return (<>
        <p><LoginLabel forName={props.id} text={props.text} /><input type={props.type} id={props.id} value={props.newForm} onChange={props.onChange} name={props.name} /></p>
    </>);
}

export default LoginInput;