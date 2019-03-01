(function($) {
    /**
     * Custom Albanian package. It's included in the dist, so you do NOT need to include it to your head tag
     * The only reason I put it here is that you can clone it, and translate it into your language
     */
    $.fn.bootstrapValidator.i18n = $.extend(true, $.fn.bootstrapValidator.i18n, {
        base64: {
            'default': 'Please enter a valid base 64 encoded'
        },
        between: {
            'default': 'Ju lutem vendosni një vlerë të saktë ndërmjet %s dhe %s',
            notInclusive: 'Ju lutem vendosni një vlerë ndërmjet numrave %s dhe %s'
        },
        callback: {
            'default': 'Ju lutem vendosni një vlerë të saktë'
        },
        choice: {
            'default': 'Ju lutem vendosni një vlerë të saktë',
            less: 'Ju lutem zgjidhni minimalisht %s opsione',
            more: 'Ju lutem zgjidhni maksimalisht %s opsione',
            between: 'Ju lutem zgjidhni %s - %s opsione'
        },
        color: {
            'default': 'Ju lutem vendosni një ngjyrë të saktë'
        },
        creditCard: {
            'default': 'Ju lutem vendosni një vlerë të saktë për numrin e kartës së kreditit'
        },
        cusip: {
            'default': 'Ju lutem vendosni një vlerë të saktë Për numrin CUSIP'
        },
        cvv: {
            'default': 'Ju lutem vendosni një vlerë të saktë për numrin CVV'
        },
        date: {
            'default': 'Ju lutem vendosni një vlerë të saktë date',
            min: 'Ju lutem vendosni një datë pas %s',
            max: 'Ju lutem vendosni një datë para %s',
            range: 'Ju lutem vendosni një datë ndërmjet %s - %s'
        },
        different: {
            'default': 'Ju lutem vendosni një vlerë tjetër'
        },
        digits: {
            'default': 'Ju lutem vendosni vetëm nurma'
        },
        ean: {
            'default': 'Ju lutem vendosni një vlerë të saktë për numrin EAN'
        },
        emailAddress: {
            'default': 'Ju lutem vendosni një adresë emaili të saktë'
        },
        file: {
            'default': 'Ju lutem zgjidhni një file të saktë'
        },
        greaterThan: {
            'default': 'Ju lutem vendosni një vlerë më të madhe ose të barabartë me %s',
            notInclusive: 'Ju lutem vendosni një vlerë më të madhe se %s'
        },
        grid: {
            'default': 'Ju lutem vendosni një vlerë të saktë për GRId'
        },
        hex: {
            'default': 'Ju lutem vendosni një numër të saktë hexadecimal'
        },
        hexColor: {
            'default': 'Ju lutem vendosni një vlerë të saktë hex për ngjyrën'
        },
        iban: {
            'default': 'Ju lutem vendosni një vlerë të saktë për IBAN',
            countryNotSupported: 'Numri i vendosur: %s nuk suportohet',
            country: 'Ju lutem vendosni një vlerë të saktë për numrin e IBAN në %s',
            countries: {
                AD: 'Andorra',
                AE: 'Emiratet e Bashkuara Arabe',
                AL: 'Shqipëria',
                AO: 'Angola',
                AT: 'Austri',
                AZ: 'Azerbajxhani',
                BA: 'Bosnja dhe Hercegovina',
                BE: 'Belgjikë',
                BF: 'Burkina Faso',
                BG: 'Bullgari',
                BH: 'Bahrein',
                BI: 'Burundi',
                BJ: 'Benin',
                BR: 'Brazil',
    CH: 'Zvicra',
    CI: 'Bregu i Fildishtë',
    CM: 'Kameruni',
    CR: 'Kosta Rika',
    CV: 'Cape Verde',
    CY: 'Qipro',
    CZ: 'Republika Çeke',
    DE: 'Gjermania',
    DK: 'Danimarka',
    DO: 'Republika Domenikane',
    DZ: 'Algjeria',
    EE: 'Estoni',
    ES: 'Spanja',
    FI: 'Finlandë',
    FO: 'Ishujt Faroe',
    FR: 'Franca',
    GB: 'Mbretëria e Bashkuar',
    GE: 'Gjeorgjia',
    GI: 'Gjibraltar',
    GL: 'Grenlandë',
    GR: 'Greqia',
    GT: 'Guatemala',
    HR: 'Kroacia',
    HU: 'Hungaria',
    IE: 'Irlanda',
    IL: 'Izraeli',
    IR: 'Irani',
    IS: 'Islanda',
    IT: 'Italia',
    JO: 'Jordan',
    KW: 'Kuvajt',
    KZ: 'Kazakistan',
    LB: 'Liban',
    LI: 'Lihtenshtajni',
    LT: 'Lituania',
    LU: 'Luksemburg',
    LV: 'Letonia',
    MC: 'Monako',
    MD: 'Moldavia',
    ME: "Mali i Zi",
    MG: 'Madagaskar',
    MK: 'Maqedonia',
    ML: 'Mali',
    MR: 'Mauritania',
    MT: 'Malta',
    MU: 'Mauritius',
    MZ: 'Mozambik',
    NL: 'Holandë',
    JO: 'Norvegjia',
    PK: 'Pakistani',
    PL: 'Poloni',
    PS: 'Palestina',
    PT: 'Portugali',
    QA: 'Katar',
    RO: 'Rumania',
    RS: 'Serbia',
    SA: 'Arabia Saudite',
    SE: 'Suedia',
    SI: 'Sllovenia',
    SK: 'Sllovakia',
    SM: 'San Marino',
    SN: 'Senegal',
    TN: 'Tunizi',
    TR: 'Turqia',
    VG: 'Virgin Islands, British'
}
},
id: {
    'default': 'Ju lutem vendosni një numër identifikimi të saktë',
    countryNotSupported: 'Kodi i shtetit %s nuk suportohet',
    country: 'Ju lutem vendosni një numër identifikimi të saktë në %s',
    countries: {
        BA: 'Bosnja dhe Hercegovina',
        BG: 'Bullgari',
        BR: 'Brazil',
        CH: 'Zvicra',
        CL: 'Kili',
        CN: 'Kina',
        CZ: 'Republika Çeke',
        DK: 'Danimarka',
        EE: 'Estoni',
        ES: 'Spanja',
        FI: 'Finlandë',
        HR: 'Kroacia',
        IE: 'Irlanda',
        IS: 'Islanda',
        LT: 'Lituania',
        LV: 'Letonia',
        ME: 'Mali i Zi',
        MK: 'Maqedonia',
        NL: 'Holandë',
        RO: 'Rumania',
        RS: 'Serbia',
        SE: 'Suedia',
        SI: 'Sllovenia',
        SK: 'Sllovakia',
        SM: 'San Marino',
        TH: 'Thailand',
        ZA: 'Afrika e Jugut'
    }
},
identical: {
    'default': 'Ju lutem vendosni të njëjtë vlerë'
},
imei: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin IMEI'
},
imo: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin IMO'
},
integer: {
    'default': 'Ju lutem vendosni një numër të saktë'
},
ip: {
    'default': 'Ju lutem vendosni një vlerë të saktë për adresën IP',
    ipv4: 'Ju lutem vendosni një vlerë të saktë për adresën IPv4',
    ipv6: 'Ju lutem vendosni një vlerë të saktë për adresën IPv6'
},
isbn: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin ISBN'
},
isin: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin ISIN'
},
ismn: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin ISMN'
},
issn: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin ISSN'
},
lessThan: {
    'default': 'Ju lutem vendosni një vlerë më të vogël ose të barabartë me %s',
    notInclusive: 'Ju lutem vendosni një vlerë më të vogël se %s'
},
mac: {
    'default': 'Ju lutem vendosni një vlerë të saktë për adresën MAC'
},
meid: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin MEID'
},
notEmpty: {
    'default': 'Ju lutem vendosni një vlerë'
},
numeric: {
    'default': 'Ju lutem vendosni një vlerë të saktë float'
},
phone: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin e telefonit',
    countryNotSupported: 'Kodi i shtetit %s nuk suportohet',
    country: 'Ju lutem vendosni një vlerë të saktë për numrin e telefonit në %s',
    countries: {          
        BR: 'Brazil',
        CN: 'Kina',
        CZ: 'Republika Çeke',
        DE: 'Gjermani',
        DK: 'Danimarkë',
        ES: 'Spanjë',
        FR: 'Francë',
        GB: 'Mbretëri e Bashkuar',
        MA: 'Marok',
        PK: 'Pakistan',
        RO: 'Rumani',
        RU: 'Rusi',
        SK: 'Sllovaki',
        TH: 'Tajlandë',
        SHBA: 'SHBA',
        VE: 'Venezuelë'
    }
},
regexp: {
    'default': 'Ju lutem vendosni një vlerë që i korrespondon formatit të caktuar'
},
remote: {
    'default': 'Ju lutem vendosni një vlerë të saktë'
},
rtn: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin RTN'
},
sedol: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin SEDOL'
},
siren: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin SIREN'
},
siret: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin SIRET'
},
step: {
    'default': 'Ju lutem vendosni një vlerë të saktë %s'
},
stringCase: {
    'default': 'Ju lutem vendosni vetëm shkronja të vogla',
    upper: 'Ju lutem vendosni vetëm shkronja të mëdha'
},
stringLength: {
    'default': 'Ju lutem vendosni një vlerë me gjatësi të saktë',
    less: 'Ju lutem vendosni më pak se %s karaktere',
    more: 'Ju lutem vendosni më shumë se %s karaktere',
    between: 'Ju lutem vendosni një vlerë me jo më shumë se %s dhe jo më pak se %s karaktere'
},
uri: {
    'default': 'Ju lutem vendosni një vlerë të saktë për URI'
},
uuid: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin UUID',
    version: 'Ju lutem vendosni një vlerë të saktë për numrin UUID në versionin %s'
},
vat: {
    'default': 'Ju lutem vendosni një vlerë të saktë për TVSH',
    countryNotSupported: 'Kodi i shtetit %s nuk suportohet',
    country: 'Ju lutem vendosni një vlerë të saktë për TVSH në %s',
    countries: {
        AT: 'Austri',
        BE: 'Belgjikë',
        BG: 'Bullgari',
        BR: 'Brazil',
        CH: 'Zvicra',
        CY: 'Qipro',
        CZ: 'Republika Çeke',
        DE: 'Gjermani',
        DK: 'Danimarkë',
        EE: 'Estoni',
        ES: 'Spanjë',
        FI: 'Finlandë',
        FR: 'Franca',
        GB: 'Mbretëri e Bashkuar',
        GR: 'Greqi',
        HU: 'Hungari',
        HR: 'Kroaci',
        IE: 'Irlandë',
        IS: 'Islandë',
        IT: 'Itali',
        LT: 'Lituani',
        LU: 'Luksemburg',
        LV: 'Letoni',
        MT: 'Maltë',
        NL: 'Holandë',
        JO: 'Norvegji',
        PL: 'Poloni',
        PT: 'Portugali',
        RO: 'Rumani',
        RU: 'Rusi',
        RS: 'Serbi',
        SE: 'Suedi',
        SI: 'Slloveni',
        SK: 'Sllovaki',
        VE: 'Venezuelë',
        ZA: 'Afrikë e Jugut'
    }
},
vin: {
    'default': 'Ju lutem vendosni një vlerë të saktë për numrin VIN'
},
zipCode: {
    'default': 'Ju lutem vendosni një vlerë të saktë për kodin postar',
    countryNotSupported: 'Kodi i shtetit %s nuk suportohet',
    country: 'Ju lutem vendosni një vlerë të saktë për kodin postar në %s',
    countries: {
        AT: 'Austri',
        BR: 'Brazil',
        CA: 'Kanada',
        CH: 'Zvicër',
        CZ: 'Republika Çeke',
        DE: 'Gjermani',
        DK: 'Danimarkë',
        FR: 'Francë',
        GB: 'Mbretëria e Bashkuar',
        IE: 'Irlandë',
        IT: 'Itali',
        MA: 'Marok',
        NL: 'Holandë',
        PT: 'Portugali',
        RO: 'Rumani',
        RU: 'Rusi',
        SE: 'Suedi',
        SG: 'Singapor',
        SK: 'Sllovaki',
        SHBA: 'SHBA'
    }
}
});
}(window.jQuery));
