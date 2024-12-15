import axios from "axios";

type formDataType = {
    position: string
    companyname: string
    location: string
    responsibility: string
    workfrom: {
        year: number | undefined
        day: number | undefined
        month: number | undefined
    }
    workto: {
        year: number | undefined
        day: number | undefined
        month: number | undefined
    }
}

const experienceApi = {
    createExperience(formData: formDataType, profileId: string | null) {
        return axios.post(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/experience/create?profileId=${profileId}`, formData, {
            withCredentials: true
        }).then(response => response.data);
    },
    deleteExperience(experienceId: string | undefined) {
        return axios.delete(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/experience/delete/${experienceId}`, {
            withCredentials: true
        }).then(response => response.data);
    },
    updateExperience(formData: formDataType, experienceId: string) {
        return axios.put(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/experience/update/${experienceId}`, formData, {
            withCredentials: true
        }).then(response => response.data);;
    }
}


export default experienceApi;