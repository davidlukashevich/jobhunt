import axios from "axios"

type formDataType = {
    universityName: string
    educationLevel: string
    fieldOfStudy: string
    specialization: string
    studyFrom: {
        year: number | undefined
        day: number | undefined
        month: number | undefined
    }
    studyTo: {
        year: number | undefined
        day: number | undefined
        month: number | undefined
    }
}

const educationApi = {
    createEducation(formData: formDataType, profileId: string | null) {
        return axios.post(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/University/create?profileId=${profileId}`, formData, {
            withCredentials: true
        }).then(response => response.data);;
    },
    deleteEducation(educationId: string | undefined) {
        return axios.delete(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/University/delete/${educationId}`, {
            withCredentials: true
        })
    },
    updateEducation(formData: formDataType, educationId: string) {
        return axios.put(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/University/update/${educationId}`, formData, {
            withCredentials: true
        })
    }
}

export default educationApi;