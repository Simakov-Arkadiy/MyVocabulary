import React from 'react';
import LoginLabel from './LoginLabel.jsx';
function LoginInput(props)
{
    
    return (<>
        <p><LoginLabel forName={props.id} text={props.text} /><input type={props.type} id={props.id} /></p>
    </>);
}

export default LoginInput;