import axios from "axios";

type formDataType = {
    firstName: string
    lastName: string
    email: string
    mobile: string
    aboutUser: string
    resume: File | null
    jobId: string | undefined
    createdBy: string | null
}

const jobApplicationApi = {
    getAllJobApplicationsByUserId(userId: string | null) {
        return axios.get(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/jobapplication/createdBy/${userId}`, {
            withCredentials: true
        }).then(response => response.data);
    },
    createJobApplication(formData: formDataType) {
        const form = new FormData();
        form.append('firstName', formData.firstName);
        form.append('lastName', formData.lastName);
        form.append('email', formData.email);
        form.append('mobile', formData.mobile);
        form.append('aboutUser', formData.aboutUser);
        if (formData.resume instanceof File) {
            form.append('Cv', formData.resume); 
        }
        form.append('jobId', formData.jobId as string);
        form.append('createdBy', formData.createdBy as string);

        return axios.post('https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/jobApplication/create', form, {
            withCredentials: true
        });
    }
}

export default jobApplicationApi;