import axios from "axios"

type formDataType = {
    title: string
    companyName: string
    operationMode: string
    contractType: string
    jobLevel: string
    responsibilities: string
    requirements: string
    country: string
    city: string
    street: string
    file: File | null
    type: string
    technology: string
    createdBy: string | null
    aboutCompany: string
    salary: string
}

type jobDetailsType = {
    title: string
    companyName: string
    operationMode: string
    contractType: string
    jobLevel: string
    responsibilities: string[]
    requirements: string[]
    address: {
        country: string
        city: string
        street: string
        id: string
    }
    type: string
    technology: string
    createdBy: string | null
    aboutCompany: string
    salary: string
}

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
    getJobById(id: string | undefined) {
        return axios.get(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/job/${id}`).then(response => response.data);
    },
    getAllJobByUserId(userId: string | null) {
        return axios.get(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/job/createdBy/${userId}`, {
            withCredentials: true
        }).then(response => response.data);
    },
    createJob(formData: formDataType) {
        const form = new FormData();
        form.append('title', formData.title);
        form.append('companyName', formData.companyName);
        form.append('operationMode', formData.operationMode);
        form.append('contractType', formData.contractType);
        form.append('jobLevel', formData.jobLevel);
        form.append('responsibilities', formData.responsibilities);
        form.append('requirements', formData.requirements);
        form.append('country', formData.country);
        form.append('city', formData.city);
        form.append('street', formData.street);
        form.append('file', formData.file as File);
        form.append('type', formData.type);
        form.append('technology', formData.technology);
        form.append('createdBy', formData.createdBy as string);
        form.append('aboutCompany', formData.aboutCompany);
        form.append('salary', formData.salary);

        return axios.post('https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/job/create', form, {
            withCredentials: true
        });
    },
    updateJob(jobId: string | undefined, jobDetails: jobDetailsType) {
        const form = new FormData();
        form.append('title', jobDetails.title);
        form.append('companyName', jobDetails.companyName);
        form.append('operationMode', jobDetails.operationMode);
        form.append('contractType', jobDetails.contractType);
        form.append('jobLevel', jobDetails.jobLevel);
        form.append('responsibilities', jobDetails.responsibilities.join('.'));
        form.append('requirements', jobDetails.requirements.join('.'));
        form.append('country', jobDetails.address.country);
        form.append('city', jobDetails.address.city);
        form.append('street', jobDetails.address.street);
        form.append('type', jobDetails.type);
        form.append('technology', jobDetails.technology);
        form.append('createdBy', jobDetails.createdBy as string);
        form.append('aboutCompany', jobDetails.aboutCompany);
        form.append('salary', jobDetails.salary);

        return axios.put(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/job/update/${jobId}`, form, {
            withCredentials: true
        });
    },
    deleteJob(jobId: string | undefined, addressId: string | undefined, imageId: string | undefined) {
        return axios.delete(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/job/delete/${jobId}?addressId=${addressId}&imageId=${imageId}`, {
            withCredentials: true
        }).catch(err => {
            console.log(err);
        })
    }
}

export default jobApi