import React from 'react';
import Login from './Login.jsx'
function LoginPanel() {
    var LoginPanel = {
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
    return (<div style={LoginPanel}>
                 <Login/>
            </div>);
}

export default LoginPanel;