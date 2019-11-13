using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BlazorWithIdentity.Shared.Enums
{
    public enum EspecialidadesEnum
    {
        [Description("Anestesiología y Reanimación")]
        Anestesiologia,
        [Description("Medicina Interna")]
        MedicinaInterna,
        [Description("Cardiología")]
        Cardiologia,
        [Description("Neumología")]
        Neumologia,
        [Description("Uci")]
        Uci,
        [Description("Cirugía General")]
        CirugiaGeneral,
        [Description("Radiología")]
        Radiologia,
        [Description("Cirugía Ortopédica y Traumatología")]
        Traumatologia,
        [Description("Medicina Preventiva")]
        MedicinaPreventiva,
        [Description("Oncología Radioterápica")]
        OncologiaRadioterapica,
        [Description("Medicina Nuclear")]
        MedicinaNuclear,
        [Description("Psiquiatría")]
        Psiquiatria,
        [Description("Urologia")]
        Urologia,
        [Description("Oncología Médica")]
        OncologiaMedica,
        [Description("Dermatología")]
        Dermatologia,


        [Description("Medicina Familiar y Comunitaria")]
        MedicinaFamiliarComunitaria,
        [Description("Medicina Intensiva")]
        MedicinaIntensiva,
        [Description("Radiodiagnóstico")]
        Radiodiagnostico

    }
}
