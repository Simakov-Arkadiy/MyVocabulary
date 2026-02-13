import React from 'react';
function LoginLabel(props) {
    const {
        forName,
        text

    } = props

    return (<label for={forName}>{text} </label>);
}

export default LoginLabel;