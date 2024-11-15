import axios from "axios"

const jobApi = {
    getAllJobs() {
        return axios.get('https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/job').then(response => response.data);
    },
    getAllJobsByTitle(title: string) {
        return axios.get(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/job/bytitle?title=${title}`).then(response => response.data);
    },
    getAllJobsByFilter(type: string = '', level: string = '', technology: string = '') {
        return axios.get(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/job/byFilter?type=${type}&level=${level}&technology=${technology}`).then(response => response.data);
    },
    getJobById(id:string | undefined) {
        return axios.get(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/job/${id}`).then(response => response.data);
    }
}

export default jobApi