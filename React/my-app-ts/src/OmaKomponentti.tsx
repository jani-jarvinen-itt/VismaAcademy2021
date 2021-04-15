import React from 'react';

interface OmaKomponenttiProps {
    nimi: string;
}

class OmaKomponentti extends React.Component<OmaKomponenttiProps, {}> {
    render() {
        const muuttuja = "Testitesti";

        return <>
            <h1>Moi, olen OmaKomponentti.tsx! {muuttuja}</h1>
            <p>Tervehdys {this.props.nimi}!</p>
        </>;
    }
}

export default OmaKomponentti;
